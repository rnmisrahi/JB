using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcClientValidation.Models;

namespace MvcClientValidation.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Register()
        {
            return View(new Member());
        }

        [HttpPost]
        public ActionResult Register(Member member)
        {
            if (ModelState.IsValid)
            {
                Response.Write("Page is valid");
            }
            else
            {
                Response.Write("Page contains errors");
            }
            return View(member);
        }

        //public ActionResult CheckNicname(string nicname)
        //{
        //    if (nicname.Contains("a"))
        //    {
        //        return Json(string.Format("{0} is reserved, enter another nic", nicname), JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(true, JsonRequestBehavior.AllowGet);
        //    }

        //}

        public ActionResult CheckNicname(Member member)
        {
            if (member.Nicname.Contains("a"))
            {
                return Json(string.Format("{0} is reserved, enter another nic", member.Nicname), JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }

        }
    }
}