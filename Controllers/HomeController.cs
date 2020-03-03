using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;
using CongThongTin.Models;
using CongThongTin.App_Data;

namespace CongThongTin.Controllers
{
    public class HomeController : Controller
    {

        //congthongtinContext db = new congthongtinContext();

        private readonly congthongtinContext db;
        public HomeController(congthongtinContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            ViewBag.listException = db.TbException.ToList();
            return View();

            //var listException = db.TbException.ToList();
            //return Ok(listException);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
