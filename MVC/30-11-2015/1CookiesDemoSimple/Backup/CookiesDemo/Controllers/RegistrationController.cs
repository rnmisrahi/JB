using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CookiesDemo.Models;

namespace CookiesDemo.Controllers
{
    public class RegistrationController : Controller
    {
        //
        // GET: /Registration/

        public ActionResult Register()
        {
            RegistrationInfo info = new RegistrationInfo();
            HttpCookie c = Request.Cookies["user"];
            if (c != null)
            {
                info.Username = c["name"];
                info.Profession = c["profession"];
                info.UserID = int.Parse(c["userid"]);
                info.IsRegistered = true;
            }
            return View(info);
        }

        [HttpPost]
        public ActionResult Register(RegistrationInfo info)
        {
            HttpCookie c = new HttpCookie("user", "");
            c.Expires = DateTime.Now.AddMinutes(3);
            c["name"] = info.Username;
            c["profession"] = info.Profession;
            c["userid"] = info.UserID.ToString();
            info.IsRegistered = true;
            Response.Cookies.Add(c);
            return View(info);
        }
    }
}
