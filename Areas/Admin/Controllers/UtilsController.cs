using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CongThongTin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CongThongTin.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UtilsController : Controller
    {
        [Route("get-captcha")]
        public FileResult GetCaptcha()
        {
            var captcha = new Captcha();
            HttpContext.Session.SetString("captchas", captcha.Text);
            return File(captcha.ImageAsByteArray, "image/png");
        }

    }
}