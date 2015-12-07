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
            return View();
        }

        public int AddResult(Exercise e)
        {
            int result = e.First + e.Second;
            return result;
        }

    }
}
