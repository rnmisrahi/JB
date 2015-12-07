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

    }
}
