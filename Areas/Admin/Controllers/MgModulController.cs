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
    public class MgModulController : Controller
    {
        private readonly congthongtinContext db;
        public MgModulController(congthongtinContext context)
        {
            this.db = context;
        }

        public IActionResult Index()
        {
            var JControll = db.TbController
                                .Where(ct => ct.IsDelete == false && ct.ParentId != null)
                                .Select(ct =>
                                   new
                                   {
                                       ct.Id,
                                       ct.Controller,
                                       ct.Name,
                                       ct.Display,
                                       ct.Description,
                                       ct.IsActive,
                                       ct.ParentId,
                                       Jaction = ct.TbAction.Where(ac => ct.IsDelete == false).ToList()
                                   })
                                .ToList().OrderBy(ct => ct.Controller);
            var JGroupModul = db.TbController
                                .Where(ct => ct.IsDelete == false && ct.ParentId == null)
                                .Select(ct => new
                                {
                                    ct.Id,
                                    ct.Controller,
                                    ct.Name,
                                    ct.Display,
                                    ct.Description,
                                    ct.IsActive
                                }).ToList().OrderBy(ct => ct.Controller);
            return View(Json(new { JControll = JControll, JGroupModul = JGroupModul }));
        }

        [HttpPost]
        public JsonResult UpdateStatusModul(int maControll)
        {
            ResSubmit submit = new ResSubmit(true, "Cập nhật thành công");
            try
            {
                TbController controllUpdate = db.TbController.FirstOrDefault(ctr => ctr.Id == maControll);
                if (submit.success && controllUpdate == null)
                {
                    submit = new ResSubmit(false, "Cập nhật thất bại");
                }

                if (submit.success)
                {
                    controllUpdate.IsActive = !controllUpdate.IsActive;
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

        [HttpPost]
        public JsonResult EditModul(mControll mControll)
        {
            ResSubmit submit = new ResSubmit(true, "Chỉnh sửa thành công");
            try
            {
                TbController controllUpdate = db.TbController.FirstOrDefault(ctr => ctr.Id == mControll.id);
                if (submit.success && controllUpdate == null)
                {
                    submit = new ResSubmit(false, "Chỉnh sửa thất bại");
                }

                if (submit.success)
                {
                    controllUpdate.Name = mControll.name;
                    controllUpdate.Display = mControll.display;
                    controllUpdate.Description = mControll.description;
                    controllUpdate.ParentId = mControll.parentId;
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

        [HttpPost]
        public JsonResult UpdateStatusAction(int maAction)
        {
            ResSubmit submit = new ResSubmit(true, "Cập nhật thành công");
            try
            {
                TbAction actionUpdate = db.TbAction.FirstOrDefault(ctr => ctr.Id == maAction);
                if (submit.success && actionUpdate == null)
                {
                    submit = new ResSubmit(false, "Cập nhật thất bại");
                }

                if (submit.success)
                {
                    actionUpdate.IsActive = !actionUpdate.IsActive;
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

        [HttpPost]
        public JsonResult EditAction(mAction mAction)
        {
            ResSubmit submit = new ResSubmit(true, "Chỉnh sửa thành công");
            try
            {
                TbAction actionUpdate = db.TbAction.FirstOrDefault(ctr => ctr.Id == mAction.id);
                if (submit.success && actionUpdate == null)
                {
                    submit = new ResSubmit(false, "Chỉnh sửa thất bại");
                }

                if (submit.success)
                {
                    actionUpdate.Name = mAction.name;
                    actionUpdate.Display = mAction.display;
                    actionUpdate.Description = mAction.description;
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