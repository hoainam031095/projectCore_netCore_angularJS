using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CongThongTin.App_Data;
using CongThongTin.Areas.Admin.Models;
using CongThongTin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CongThongTin.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Permission]
    public class MgRoleController : Controller
    {
        private readonly congthongtinContext db;
        public MgRoleController(congthongtinContext context)
        {
            this.db = context;
        }

        public IActionResult Index()
        {
            var JRole = db.TbRoleGroup.Select(rl => new {
                rl.Id,
                rl.GroupName,
                rl.Description,
                rl.CreateDate,
                rl.IsActive
            }).ToList();

            var JRoleAction = db.TbRoleGroupAction.Select(rlAc =>  new {
                rlAc.RoleGroupId,
                rlAc.ActionId,
                rlAc.IsActive,
                rlAc.IsDelete
            }).ToList();

            var JAction = db.TbAction.Where(ac => ac.IsActive == true && ac.IsDelete == false)
                .Select(ac => new mAction
                {
                    id = ac.Id,
                    action = ac.Action,
                    name = ac.Name,
                    display = ac.Display,
                    description = ac.Description,
                    controllerId = ac.ControllerId,
                    controllerName = ac.ControllerName,
                    checkeds = false,
                }).ToList();

            var JModul = JAction
                .GroupBy(m => new
                {
                    m.controllerId,
                    m.controllerName
                }, (key, g) => new
                {
                    controlerId = key.controllerId,
                    controllerName = key.controllerName,
                    controllerDispay = db.TbController.FirstOrDefault(ctr => ctr.Id == key.controllerId).Display,
                    ListAction = g.ToList()
                }).ToList();
            return View(Json(new { JRole = JRole, JRoleAction = JRoleAction, JModul = JModul }));
        }

        [HttpPost]
        public JsonResult AddNewRole(mRole newRole)
        {
            ResSubmit submit = new ResSubmit(true, "Thêm thành công");
            try
            {
                TbRoleGroup newRoleGroup = new TbRoleGroup();
                newRoleGroup.GroupName = newRole.groupName;
                newRoleGroup.Description = newRole.description;
                newRoleGroup.CreateDate = DateTime.Now;
                newRoleGroup.IsActive = true;
                db.TbRoleGroup.Add(newRoleGroup);
                if (db.SaveChanges() < 1)
                {
                    submit = new ResSubmit(false, "Thêm thất bại");
                }
                if(submit.success)
                {
                    submit.idNew = newRoleGroup.Id;
                }
            }
            catch (Exception ex)
            {
                var settingEx = ViewBag.SettingEx as Dictionary<string, string>;
                Utils.writeLog(ex);
                submit = new ResSubmit(false, settingEx[ex.GetType().FullName]);
            }

            return Json(submit);
        }

        [HttpPost]
        public JsonResult DeleteRole(int roleId)
        {
            ResSubmit submit = new ResSubmit(true, "Xóa thành công");
            try
            {
                TbRoleGroup roleGroupDelete = db.TbRoleGroup.FirstOrDefault(ctr => ctr.Id == roleId);
                if (submit.success && roleGroupDelete == null)
                {
                    submit = new ResSubmit(false, "Xóa thất bại");
                }

                if (submit.success)
                {
                    db.TbRoleGroup.Remove(roleGroupDelete);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                var settingEx = ViewBag.SettingEx as Dictionary<string, string>;
                Utils.writeLog(ex);
                submit = new ResSubmit(false, settingEx[ex.GetType().FullName]);
            }

            return Json(submit);
        }

    }
}