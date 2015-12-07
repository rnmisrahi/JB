using RegistrationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult RegistrationPage()
        {
            return View();
        }

        public ActionResult Register(Member m)
        {
            Repository.Add(m);
            return View("RegistrationPage");
        }

        public ActionResult ShowMember(int Id)
        {
            //Member m = new Member();
            //m.Id = Id;
            //m = Repository.Members[0];
            Member m = Repository.Members.Find(x => x.Id == Id);
            return View("ShowMemberPage", m);
        }

        public ActionResult QueryMember()
        {
            Member m = new Member();
            return View("ShowMemberPage", m);
        }

    }
}
