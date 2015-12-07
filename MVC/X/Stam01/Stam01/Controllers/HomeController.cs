using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stam01.Models;

namespace Stam01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Candidate candidate)
        {
            var x = candidate;
            string s = candidate.ToString();
           return RedirectToAction("Index");
        }
    }
}