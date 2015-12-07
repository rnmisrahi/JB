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
            Exercise e = new Exercise();
            ExerciseViewModel ex = new ExerciseViewModel();
            ex.exercise = e;
            ex.Operation = operation;
            return View(ex);
        }

        public ActionResult ExerciseResult(ExerciseViewModel e) // , string operation
        {
            Exercise ex = e.exercise;
            int? f = ex.First;
            int? s = ex.Second;
            // int result;
            switch (e.Operation)
            {
                case "Add":
                    e.Result = f + s;
                    break;
                case "Subtract":
                    e.Result = f - s;
                    break;
                case "Mul":
                    e.Result = f * s;
                    break;
                case "Div":
                    e.Result = f / s;
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
