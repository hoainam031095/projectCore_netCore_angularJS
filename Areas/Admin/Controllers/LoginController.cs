using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CongThongTin.Areas.Admin.Models;
using CongThongTin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CongThongTin.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Permission]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //public IActionResult Index(string username, string password, [Required]string captcha, string remember)
        public IActionResult Index(AccountLogin account)
        {
            if (ViewBag.Error != null)
            {
                return View();
            }

            if (Utils.antiAttack(account.username) || Utils.antiAttack(account.password) || Utils.antiAttack(account.captcha))
            {
                ModelState.AddModelError("", "Form chứa dữ liệu không được phép");
                return View();
            }


            if (HttpContext.Session.GetString("captchas") == null)
            {
                ModelState.AddModelError("", "Xin mời nhập lại mã captcha");
                return View();
            }

            if ((account.captcha != HttpContext.Session.GetString("captchas").ToString()))
            {
                ModelState.AddModelError("", "Mã captcha không hợp lệ");
                return View();
            }

            var acc = new LoginModel().CheckLogin(account.username, account.password);
            if (acc != null)
            {
                if (account.remember == "on") /*remember login*/
                {
                    CookieOptions cookie = new CookieOptions();
                    DateTime now = DateTime.Now;
                    cookie.Expires = now.AddDays(7);
                    Response.Cookies.Append("userRemember", Utils.Encrypt(account.remember + "," + acc.Id.ToString() + "," + acc.UserName, "cookie"), cookie);
                }
                else /*no remember login*/
                {
                    HttpContext.Session.SetString("AccountSession", JsonConvert.SerializeObject(new AccountSession() { Id = acc.Id, UserName = acc.UserName != null ? acc.UserName : acc.Email, RoleGroupId = acc.RoleGroupId, FullName = acc.FullName }));
                }

                //var requestSplit = Request.UrlReferrer.ToString().Split('=');
                //if (requestSplit.Count() > 1)
                //{
                //    var url = requestSplit[1];
                //    if (url != null)
                //        return Redirect(url);
                //    else
                //        return RedirectToAction("Index", "Home");
                //}
                //else
                    return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Tên tài khoản hoặc mật khẩu không đúng");
                return View();
            }
        }
    }
}