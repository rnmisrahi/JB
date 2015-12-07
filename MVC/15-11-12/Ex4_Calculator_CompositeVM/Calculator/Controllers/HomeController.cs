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
            return View(new ExerciseVM { Operation = operation });
        }

        public ActionResult ExerciseResult(ExerciseVM e) // , string operation
        {
            // int result;
            switch (e.Operation)
            {
                case "Add":
                    e.Result = e.Exercise.First + e.Exercise.Second;
                    break;
                case "Subtract":
                    e.Result = e.Exercise.First - e.Exercise.Second;
                    break;
                case "Mul":
                    e.Result = e.Exercise.First * e.Exercise.Second;
                    break;
                case "Div":
                    e.Result = e.Exercise.First / e.Exercise.Second;
                    break;
                default:
                    return null;
            }
            return View("ShowExercise", e);
        }

        
    }
}
