﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Calculator
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{first}/{second}",
                defaults: new { controller = "Home", action = "Index", first = UrlParameter.Optional, second = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default1",
                url: "{controller}/{action}/{first}/{second}/{third}",
                defaults: new { controller = "Home", action = "Index", first = UrlParameter.Optional, second = UrlParameter.Optional }
            );
        }
    }
}