using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using AuthenticationDemo.Models;

namespace AuthenticationDemo
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            UserRepository users = new UserRepository();

            string encryptedPassword1 = FormsAuthentication.HashPasswordForStoringInConfigFile("aaa111", "MD5");
            users.RegisterUser(new UserDetails { UserID = 0, UserName = "Moshe", Password = encryptedPassword1, UserEmailAddress = "a@b.c" });
            string encryptedPassword2 = FormsAuthentication.HashPasswordForStoringInConfigFile("bbb222", "MD5");
            users.RegisterUser(new UserDetails { UserID = 0, UserName = "Tikva", Password = encryptedPassword2, UserEmailAddress = "b@b.c" });
        }
    }
}