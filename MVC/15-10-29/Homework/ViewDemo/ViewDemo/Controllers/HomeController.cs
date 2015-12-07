using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Message()
        {
            return View();
        }

        public ActionResult SelectView()
        {
            Random rnd = new Random();
            if (rnd.NextDouble() < 0.3)
                return View("Index");
            else if (rnd.NextDouble() < 0.6)
                return View("Message");
            else
                return View("~/Views/Trials/Display.cshtml");
        }

        public ActionResult SelectView1()
        {
            Random rnd = new Random();
            if (rnd.NextDouble() < 0.3)
                return Index();
            else if (rnd.NextDouble() < 0.6)
                return Message();
            else
                return View("~/Views/Trials/Display.cshtml");
        }

        public ActionResult Calculate()
        {
            return View();
        }
    }
}
