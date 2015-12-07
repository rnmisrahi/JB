using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserCountingApp.Models;

namespace UserCountingApp.Controllers
{
    public class CounterController : Controller
    {
        //
        // GET: /Counter/

        public ActionResult Index()
        {
            return View(CountingModel.GetInstance());
        }

    }
}
