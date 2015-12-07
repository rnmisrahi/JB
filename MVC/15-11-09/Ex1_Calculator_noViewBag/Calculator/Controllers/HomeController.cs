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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowExercise(string operation)
        {
            // ViewBag.Operation = operation;
            return View(new Exercise { Operation = operation });
        }

        public ActionResult ExerciseResult(Exercise e) // , string operation
        {
            // int result;
            switch (e.Operation)
            {
                case "Add":
                    e.Result = e.First + e.Second;
                    break;
                case "Subtract":
                    e.Result = e.First - e.Second;
                    break;
                case "Mul":
                    e.Result = e.First * e.Second;
                    break;
                case "Div":
                    e.Result = e.First / e.Second;
                    break;
                default:
                    return null;
            }
            // ViewBag.Result = result;
            // ViewBag.Operation = operation;
            return View("ShowExercise", e);
        }

        
    }
}
