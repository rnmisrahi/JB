using AjaxNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxNews.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        private bool acceptNews(string )
        [HttpPost]
        public ActionResult Index(NewsReport report)
        {
            if (report.News.Length > 5)
            {
                return Json(new { success = false, responseText = "Messages was rejected" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                NewsRepository.AllNews.Insert(0, report);
                return Json(new { success = true, responseText = "" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult GetAllNews()
        {
            return PartialView("AllNews", NewsRepository.AllNews);
        }
    }
}