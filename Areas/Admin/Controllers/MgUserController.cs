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
    public class MgUserController : Controller
    {
        private readonly congthongtinContext db;
        public MgUserController(congthongtinContext context)
        {
            this.db = context;
        }

        public IActionResult Index()
        {
            var JUser = db.TbUser.Select(us => new mUser
            {
                Id = us.Id,
                UserName = us.UserName,
                FullName = us.FullName,
                Email = us.Email,
                Address = us.Address,
                Phone = us.Phone,
                Type = us.Type,
                IsActive = us.IsActive,
                Avatar = us.Avatar,
                CreateDate = us.CreateDate,
                RoleGroupId = us.RoleGroupId,
                RoleGroupName = db.TbRoleGroup.FirstOrDefault(rl => rl.Id == us.RoleGroupId).GroupName
            });

            return View(Json(new { JUser = JUser }));
        }
    }
}