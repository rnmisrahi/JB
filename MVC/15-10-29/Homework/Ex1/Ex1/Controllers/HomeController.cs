using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ex1.Controllers
{
    public class HomeController : Controller
    {
        static int countAll = 0, countHW = 0;

        public string Index()
        {
            Random rnd = new Random();
            countAll++;
            if (rnd.NextDouble() < 0.3333)
            {
                countHW++;
                return string.Format("Hello, World ({0}, {1}, {2})",countAll,countHW, countAll-countHW);
            }
            else
            {
                return string.Format("Welcome to MVC ({0}, {1}, {2})",countAll,countHW, countAll-countHW);
            }
        }

        public string Index_Solution()
        {
            Random rnd = new Random();
            if (rnd.NextDouble() < 0.3333)
            {
                return "Hello, World";
            }
            else
            {
                return "Welcome to MVC";
            }
        }

        public string GetView()
        {
            StreamReader sr = new StreamReader(@"c:\example.html");
            string text = sr.ReadToEnd();
            sr.Close();
            return text;
        }

    }
}
