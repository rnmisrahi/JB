using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionParametersDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult SelectView(int id=1)
        {
            if (id == 1)
                return View("Short");
            else if (id == 2)
                return View("Long");
            else
            {
                ContentResult cr = new ContentResult();
                cr.Content = "Error in view number";
                return cr;
            }
        }

    }
}
