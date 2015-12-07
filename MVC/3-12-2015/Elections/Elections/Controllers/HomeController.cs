using Elections.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Elections.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            if (Request.Cookies["AlreadyVoted"]!=null)
                return View(true);
            else
                return View(false);
        }

        [HttpPost]
        public ActionResult Index(string candidateName)
        {
            var candidate = Statistics.Candidates.FirstOrDefault(c => c.Name == candidateName);
            if (candidate != null)
            {
                candidate.VoteCount++;
                HttpCookie cookie = new HttpCookie("AlreadyVoted");
                cookie.Expires = DateTime.Now.AddMinutes(3);

                Response.Cookies.Add(cookie);
            }
            return RedirectToAction("Index");
        }


    }
}
