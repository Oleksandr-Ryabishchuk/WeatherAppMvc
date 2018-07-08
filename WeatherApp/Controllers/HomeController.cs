using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Weather()
        {
            return View();
        }

        public ActionResult WeatherMvc()
        {
            return View();
        }
        public ActionResult WeatherKnockout()
        {
            return View();
        }

        public JsonResult GetWeather()
        {
            var weath = new Weather();
            return Json(weath.GetCurrentWeather(), JsonRequestBehavior.AllowGet);
        }

       
    }
}