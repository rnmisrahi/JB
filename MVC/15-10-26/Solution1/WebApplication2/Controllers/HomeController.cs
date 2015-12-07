using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private static Random rnd = new Random();
        private static string hello = "Hello World";
        private static string welcome = "Welcome to MVC";
        private static int hits = 0;
        private static int trials = 0;

        // GET: Home
        public string Index()
        {
            trials++;
            if (isAHit()) {
                hits++;
                double prop = 100F * hits / trials;
                return hello + " : " + prop + "%";
            }
            else
                return welcome;
        }

        private static bool isAHit()
        {
            return (rnd.Next(300) < 100);
        }
    }
}