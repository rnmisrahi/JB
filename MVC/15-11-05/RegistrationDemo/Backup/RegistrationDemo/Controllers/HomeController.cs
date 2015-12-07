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

    }
}
