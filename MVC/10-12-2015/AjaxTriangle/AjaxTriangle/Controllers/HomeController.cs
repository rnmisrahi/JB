using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxTriangle.Models;

namespace AjaxTriangle.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int a, int b, int c)
        {
            //Triangle triangle = new Triangle(a, b, c);
            return View();
        }

        public ActionResult Triangle()
        {
            return View(new Triangle());
        }

        [HttpPost]
        public ActionResult Triangle(string SideA, string SideB, string SideC)
        {
            int a = int.Parse(SideA);
            int b = int.Parse(SideB);
            int c = int.Parse(SideC);
            Triangle t = new Triangle(a, b, c);
            return PartialView("Details", t);
        }
    }
}