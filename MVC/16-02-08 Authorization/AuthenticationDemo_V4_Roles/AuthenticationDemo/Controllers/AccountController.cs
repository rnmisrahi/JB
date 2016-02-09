using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AuthenticationDemo.Models;

namespace AuthenticationDemo.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Login()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginData, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                string encryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(loginData.Password, "MD5");
                UserRepository users=new UserRepository();
                UserDetails user = users.GetUserByName(loginData.Username, encryptedPassword);
                if (user!=null)
                {
                    FormsAuthentication.SetAuthCookie(loginData.Username, false);
                    return Redirect(returnUrl);
                }
                else
                {
                    ModelState.AddModelError("", "Username and/or password are not correct");
                }
            }
            return View(loginData);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
