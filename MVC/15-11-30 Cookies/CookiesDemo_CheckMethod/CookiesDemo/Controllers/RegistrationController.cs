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
        [HandleError(ExceptionType = typeof(HttpException), View = "NoCookies")]
        public ActionResult Register()
        {
            string currentUrl = CookiesCheck();
            if (currentUrl != "")
                return new RedirectResult(currentUrl);
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

        public string CookiesCheck()
        {
            string CookieName = "cookieCheck";
            string QueryString = CookieName;

            if (!Request.Browser.Cookies)
                throw new HttpException("Your browser does not support cookies");

            string currentUrl = Request.RawUrl;

            var noCookie = (Request.Cookies[CookieName] == null);
            if (noCookie && Request.QueryString[QueryString] == null)
            {
                try
                {
                    // make it expire a long time from now, that way there's no need for redirects in the future if it already exists
                    var c = new HttpCookie(CookieName, "true") { Expires = DateTime.Today.AddYears(50) };
                    Response.Cookies.Add(c);

                    currentUrl = currentUrl + (currentUrl.Contains('?') ? "&" : "?") + QueryString + "=true";
                    
                    return currentUrl;
                }
                catch
                {
                    return string.Empty;
                }
            }

            if (noCookie)
                throw new HttpException("You do not have cookies enabled.");
            return string.Empty;
        }

        [HttpPost]
        public ActionResult Register(RegistrationInfo info)
        {
            HttpCookie c = new HttpCookie("user", "");
            c.Expires = DateTime.Now.AddMinutes(1);
            c["name"] = info.Username;
            c["profession"] = info.Profession;
            c["userid"] = info.UserID.ToString();
            info.IsRegistered = true;
            Response.Cookies.Add(c);
            return View(info);
        }
    }
}
