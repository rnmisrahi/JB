using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxMemberList.Models;

namespace AjaxMemberList.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        MembersDBEntities dbContext = new MembersDBEntities();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult All()
        {
            var members = dbContext.Members;
            return PartialView("_Members", members);
        }

        public PartialViewResult Top3()
        {
            var members = dbContext.Members.OrderByDescending(m=>m.Id).Take(3);
            return PartialView("_Members", members);
        }

        public PartialViewResult Bottom3()
        {
            var members = dbContext.Members.OrderBy(m => m.Id).Take(3);
            return PartialView("_Members", members);
        }
    }
}
