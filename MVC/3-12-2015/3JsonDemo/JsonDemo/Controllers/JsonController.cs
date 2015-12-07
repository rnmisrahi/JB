using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JsonDemo.Controllers
{
    public class JsonController : Controller
    {
        //
        // GET: /Json/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetData()
        {
            return Json(JsonDemo.Models.ComputerLab.Computers, JsonRequestBehavior.AllowGet);
        }
    }
}
