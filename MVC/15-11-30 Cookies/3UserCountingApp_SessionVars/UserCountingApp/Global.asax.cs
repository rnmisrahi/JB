using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using UserCountingApp.Models;

namespace UserCountingApp
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
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start()
        {
            // Session.Timeout = 1;
            
            var countingModel = CountingModel.GetInstance();
            countingModel.ConcurrentUsers++;
            countingModel.ApplicationSessionUsers++;
            countingModel.ApplicationAllUsers++;
            Session["ClickCount"] = 0;
        }

        protected void Session_End()
        {
            var countingModel = CountingModel.GetInstance();
            countingModel.ConcurrentUsers--;
        }
    }
}