using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using AjaxDemo.Models;

namespace AjaxDemo.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            Person person = PersonListModel.Members.Find(p => p.ID == id);
            if (person == null)
                return PartialView("Error");
            else
                // return PartialView("Details", person);
                return Json(person, JsonRequestBehavior.AllowGet);
        }

        //[HttpPost]
        //public ActionResult Index(int id)
        //{
        //    Person person = PersonListModel.Members.Find(p => p.ID == id);
        //    if (person == null)
        //        return PartialView("Error");
        //    else
        //        return PartialView("Details", person);
        //}
    }
}
