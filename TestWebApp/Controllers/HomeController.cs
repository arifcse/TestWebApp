using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My application description page: Details";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My contact page: 1st";

            return View();
        }
    }
}