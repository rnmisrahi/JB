using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Add()
        {
            return View(new Exercise());
        }

        public ActionResult Operation(Exercise e)
        {
            switch (e.operand)
            {
                case '+':
                    e.Result = e.First + e.Second;
                    break;
                case '-':
                    e.Result = e.First - e.Second;
                    break;
                case '*':
                    e.Result = e.First * e.Second;
                    break;
                case '/':
                    if (e.Second == 0)
                        return HttpNotFound("Division by Zero!");
                    e.Result = (double)e.First / (double)e.Second;
                    break;
                default:
                    break;
                    return HttpNotFound("Invalid Operand");
            }
            return View("Operation", e);
        }

        public ActionResult AddResult(Exercise e)
        {
            int result = e.First + e.Second;
            //ViewBag.Result = result;
            //ViewBag.First = e.First;
            //ViewBag.Second = e.Second;
            return View("Add",e);
        }

    }
}
