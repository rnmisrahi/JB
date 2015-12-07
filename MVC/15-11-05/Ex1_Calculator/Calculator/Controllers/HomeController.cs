using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Add()
        {
            return View(new Exercise());
        }

        public ActionResult AddResult(Exercise e)
        {
            int result = e.First + e.Second;
            ViewBag.Result = result;
            //ViewBag.First = e.First;
            //ViewBag.Second = e.Second;
            return View("Add", e);
        }

        public ActionResult Subtract()
        {
            return View(new Exercise());
        }

        public ActionResult SubtractResult(Exercise e)
        {
            int result = e.First - e.Second;
            ViewBag.Result = result;
            //ViewBag.First = e.First;
            //ViewBag.Second = e.Second;
            return View("Subtract", e);
        }

        public ActionResult Mul()
        {
            return View(new Exercise());
        }

        public ActionResult MulResult(Exercise e)
        {
            int result = e.First * e.Second;
            ViewBag.Result = result;
            //ViewBag.First = e.First;
            //ViewBag.Second = e.Second;
            return View("Mul", e);
        }

        public ActionResult Div()
        {
            return View(new Exercise());
        }

        public ActionResult DivResult(Exercise e)
        {
            int result = e.First / e.Second;
            ViewBag.Result = result;
            //ViewBag.First = e.First;
            //ViewBag.Second = e.Second;
            return View("Div", e);
        }

    }
}
