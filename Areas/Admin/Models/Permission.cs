using CongThongTin.App_Data;
using CongThongTin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace CongThongTin.Areas.Admin.Models
{

    public class Permission : ActionFilterAttribute
    {
        //Hàm đánh giá thuộc tính khi validate
        private void EvaluateValidationAttributes(ParameterInfo parameter, object argument, ModelStateDictionary modelState)
        {
            var validationAttributes = parameter.CustomAttributes;

            foreach (var attributeData in validationAttributes)
            {
                var attributeInstance = CustomAttributeExtensions.GetCustomAttribute(parameter, attributeData.AttributeType);

                var validationAttribute = attributeInstance as ValidationAttribute;

                if (validationAttribute != null)
                {
                    var isValid = validationAttribute.IsValid(argument);
                    if (!isValid)
                    {
                        modelState.AddModelError(parameter.Name, validationAttribute.FormatErrorMessage(parameter.Name));
                    }
                }
            }
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var actionResult = ((ControllerActionDescriptor)filterContext.ActionDescriptor).MethodInfo.ReturnType;
            string actionName = ((ControllerActionDescriptor)filterContext.ActionDescriptor).ActionName;
            string controllerName = ((ControllerActionDescriptor)filterContext.ActionDescriptor).ControllerName;
            string currentUrl = filterContext.HttpContext.Request.Path;

            Controller controller = filterContext.Controller as Controller;

            //Validate
            var descriptor = filterContext.ActionDescriptor as ControllerActionDescriptor;
            //if (descriptor != null)
            //{
            //    var parameters = descriptor.MethodInfo.GetParameters();
            //    foreach (var parameter in parameters)
            //    {
            //        var argument = filterContext.ActionArguments[parameter.Name];
            //        EvaluateValidationAttributes(parameter, argument, controller.ViewData.ModelState);
            //    }
            //}
            if (!controller.ViewData.ModelState.IsValid)
            {
                List<validateObject> validationErrors = new List<validateObject>();
                Dictionary<string, string> validationD = new Dictionary<string, string>();
                foreach (var item in controller.ViewData.ModelState)
                {
                    string key = item.Key;
                    var errors = item.Value.Errors;

                    foreach (var error in errors)
                    {
                        if (!string.IsNullOrEmpty(error.ErrorMessage))
                        {
                            //var msg = error.ErrorMessage;
                            var msg = String.Format("Xin mời nhập {0}", key);
                            validationErrors.Add(new validateObject
                            {
                                PropertyName = key,
                                ErrorMessage = msg
                            });
                        }
                    }
                }
                //Xét action result (JsonResult || ActionResult)
                if (actionResult.Name == "JsonResult")
                {
                    var resSubmit = new ResSubmit(false, "ValidateError");
                    resSubmit.extend = validationErrors;
                    filterContext.Result = new ObjectResult(resSubmit);
                }
                if (actionResult.Name == "IActionResult")
                {
                    controller.ViewBag.Error = validationErrors;
                }
            }
            //End Validate

            //Tạo Dictionary lỗi ngoại lệ
            using(congthongtinContext db = new congthongtinContext())
            {
                var listException = db.TbException.FromSqlRaw("exec [dbo].[getException]").ToList();
                controller.ViewBag.SettingEx = listException.ToDictionary(x => x.Key, x => x.ValueVi);
            }
            //End tạo dictionary

            //Ghi nhớ đăng nhập
            var ckRemember = filterContext.HttpContext.Request.Cookies["userRemember"];
            if (ckRemember != null)
            {
                var info = Utils.Decrypt(ckRemember, "cookie").Split(',');

                if (info[0] == "on")
                {
                    var idUs = Int32.Parse(info[1]);
                    var userName = info[2];
                    using (var db = new congthongtinContext())
                    {
                        TbUser user = db.TbUser.FirstOrDefault(us => us.Id == idUs && us.UserName == userName && us.IsActive == true);
                        if (user != null)
                        {
                            filterContext.HttpContext.Session.SetString("AccountSession", JsonConvert.SerializeObject(new AccountSession() { Id = user.Id, UserName = user.UserName != null ? user.UserName : user.Email, RoleGroupId = user.RoleGroupId, FullName = user.FullName }));
                        }
                    }
                }

            }
            //End cookie ghi nhớ đăng nhập

            //Check session
            List<string> actionSkip = new List<string>() { "Logout", "GetCaptcha" };
            var acSession = filterContext.HttpContext.Session.GetString("AccountSession");
            if (acSession == null && controllerName != "Login")
            {
                switch (actionResult.Name)
                {
                    case "JsonResult":
                        var resSubmit = new ResSubmit(false, "Bạn cần đăng nhập!");
                        filterContext.Result = new ObjectResult(resSubmit);
                        break;
                    case "IActionResult":
                        filterContext.Result = new RedirectResult("admin/Login?url=" + currentUrl);
                        break;
                }
            }
            else
            {
                if (controllerName != "Login" && !actionSkip.Contains(actionName))
                {
                    AccountSession sessionAccount = acSession == null ? default(AccountSession) : JsonConvert.DeserializeObject<AccountSession>(acSession);
                    using (var db = new congthongtinContext())
                    {
                        TbUser user = db.TbUser.FirstOrDefault(us => us.Id == sessionAccount.Id && us.UserName == sessionAccount.UserName && us.IsActive == true);
                        if (user == null)
                        {
                            filterContext.Result = new RedirectResult("admin/Login?url=" + currentUrl);
                        }
                        else
                        {
                            if (user.UserName != "admin1234$#@!")
                            {
                                var route = db.TbRoute.Where(m => m.Namespace == "CongThongTin.Areas.Admin.Controllers" &&
                                                                m.ControllerName == controllerName &&
                                                                m.ActionName == actionName).FirstOrDefault();
                                if (route != null)
                                {
                                    var idG = user.RoleGroupId;
                                    var role = db.TbRoleGroup.Where(m => m.Id == idG).FirstOrDefault();
                                    if (role == null)
                                    {
                                        switch (actionResult.Name)
                                        {
                                            case "JsonResult":
                                                var jsonResult = new ResSubmit(false, "Tài khoản không đủ quyền thực hiện hành động!");
                                                filterContext.Result = new ObjectResult(jsonResult);
                                                //filterContext.HttpContext.Response.StatusCode = 205;
                                                break;
                                            case "IActionResult":
                                                filterContext.Result = new ViewResult
                                                {
                                                    //MasterName = "~/Areas/Admin/Views/Layout/AdminLayout.cshtml",
                                                    ViewName = "~/Areas/Admin/Views/AccessDenied/Index2.cshtml",
                                                    //ViewData = filterContext.Controller.ViewData,
                                                    //TempData = filterContext.Controller.TempData
                                                };
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //End check session

            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {

        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {

        }
    }
}
