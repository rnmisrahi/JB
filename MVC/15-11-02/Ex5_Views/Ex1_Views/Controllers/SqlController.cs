using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ex1_Views.Controllers
{
    public class SqlController : Controller
    {
        //
        // GET: /Sql/

        public ActionResult BasicTSQL()
        {
            return View();
        }

        public ActionResult UpdateQuery()
        {
            return View("~/UpdateQuery.cshtml");
        }
    }
}
