using RegistrationDemo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/


        public ActionResult Index()
        {
            return View(Repository.Members);
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

        [ActionName("RegisterMe")]
        public ActionResult Register(int k)
        {
            return null;
        }

        public ActionResult Display(int id)
        {
            Member member = Repository.Members.FirstOrDefault(m => m.Id == id);
            if (member != null)
                return View(member);
            else
                return new ContentResult {  Content = string.Format("{0} not found", id) };
        }

        public ActionResult Edit(int id)
        {
            Debug.WriteLine("NU?");
            Debug.WriteLine("Request.Params[0] {0}", Request.Params[0]);
            Member member = Repository.Members.FirstOrDefault(m => m.Id == id);
            if (member != null)
            {
                return View(member);
            }
            else
                return new ContentResult { Content = string.Format("{0} not found", id) };
        }

        [HttpPost]
        public ActionResult Edit(Member member, int prevId)
        {
            Debug.WriteLine("Query String: {0}", Request.QueryString);
            Member currentMember = Repository.Members.FirstOrDefault(m => m.Id == prevId);
            if (member != null)
            {
                currentMember.Id = member.Id;
                currentMember.Name = member.Name;
                currentMember.Seniority = member.Seniority;
                return RedirectToAction("Index");
            }
            else
                return new ContentResult { Content = string.Format("{0} not found", prevId) };
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Member currentMember = Repository.Members.FirstOrDefault(m => m.Id == id);
            if (currentMember != null)
            {
                Repository.Members.Remove(currentMember);
                return RedirectToAction("Index");
            }
            else
                return new ContentResult { Content = string.Format("{0} not found", id) };

        }
    }
}
