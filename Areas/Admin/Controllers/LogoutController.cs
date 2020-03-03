using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CongThongTin.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LogoutController : Controller
    {
        public IActionResult Index()
        {
            if(Request.Cookies.ContainsKey("userRemember"))
                Response.Cookies.Delete("userRemember");

            HttpContext.Session.Remove("AccountSession");
            return RedirectToAction("Index","Login");
        }
    }
}