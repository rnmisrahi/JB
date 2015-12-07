using _1_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_Calculator.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

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
            return View("Add",e);
        }

    }
}
