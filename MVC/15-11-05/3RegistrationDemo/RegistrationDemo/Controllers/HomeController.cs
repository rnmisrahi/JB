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


        public ActionResult DisplayMembers()
        {
            return View(Repository.Members);
        }

        public ActionResult Index()
        {
            return View();
        }

        // [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Member m)
        {
            Repository.Add(m);
            // return View("RegistrationPage");
            return RedirectToAction("Register");
        }

        //[HttpPost]
        public ActionResult EditMember(int id)
        {
            Member member = Repository.Members.FirstOrDefault(m => m.Id == id);
            if (member != null)
                return View(member);
            else
                return new ContentResult { Content = string.Format("{0} not found", id) };
        }

        [HttpPost]
        public ActionResult SaveMember(Member editedMember)
        {
            Member member = Repository.Members.FirstOrDefault(m => m.Id == editedMember.Id);
            if (member != null)
            {
                member.Name = editedMember.Name;
                member.Seniority = editedMember.Seniority;
                return RedirectToAction("Index");
            }
            else
                return new ContentResult { Content = string.Format("{0} not found", editedMember.Id) };
        }

        [ActionName("RegisterMe")]
        public ActionResult Register(int k)
        {
            return null;
        }

        public ActionResult DisplayMember(int id)
        {
            Member member = Repository.Members.FirstOrDefault(m => m.Id == id);
            if (member != null)
                return View(member);
            else
                return new ContentResult {  Content = string.Format("{0} not found", id) };
        }

    }
}
