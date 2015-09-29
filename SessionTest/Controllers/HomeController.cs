using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string session, string application, string tempData)
        {
            Session["session"] = session;
            HttpContext.Application["application"] = application;
            TempData["temp"] = tempData;
            return RedirectToAction("About");
        }

        public ActionResult About()
        {
            var session = Session["session"] as String;
            var application = HttpContext.Application["application"] as String;
            var tempData = TempData["temp"] as String;
            ViewBag.Message = "Session is " + (String.IsNullOrEmpty(session) ? "not " : "") + "supported, " + "Application is " + ((String.IsNullOrEmpty(application) ? "not " : "") + "supported") + ", Temp Data is " + ((String.IsNullOrEmpty(tempData) ? "not " : "") + "supported");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}