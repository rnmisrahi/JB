using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ex1.Controllers
{
    public class HomeController : Controller
    {

        private static int count = 0;

        public string Index()
        {
            //return View();
            count++;
            Random rnd = new Random();
            if (rnd.NextDouble() < 0.33333)
                return "Hello World";
            else
                return "Welcome to MVC";
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}