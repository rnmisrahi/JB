using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private static string htmlFile = HttpRuntime.AppDomainAppPath + "App_Data" + Path.DirectorySeparatorChar + "Index.html";

        // GET: Home
        public string Index()
        {
            return GetView();
        }

        public string GetView()
        {
            try
            {
                if (!System.IO.File.Exists(htmlFile)){
                    throw new Exception("File " + htmlFile + " NOT found");
                }
                StreamReader sr = new StreamReader(htmlFile);
                String res = sr.ReadToEnd();
                return res;
            }
            catch (Exception ex)
            {
                return "Unexpected error: " + ex.Message; //I know there is a risk showing users an exception that can reveal more than I may want to reveal
            }
        }
    }
}