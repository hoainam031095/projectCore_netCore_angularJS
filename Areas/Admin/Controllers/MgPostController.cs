using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CongThongTin.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CongThongTin.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Permission]
    public class MgPostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}