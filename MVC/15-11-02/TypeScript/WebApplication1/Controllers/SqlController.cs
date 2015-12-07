using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class SqlController : Controller
    {
        // GET: Sql
        public ActionResult BasicTSQL()
        {
            ViewResult vr = new ViewResult();
            return View();
        }

        public ActionResult UpdateSQL()
        {
            return View();
        }
    }
}