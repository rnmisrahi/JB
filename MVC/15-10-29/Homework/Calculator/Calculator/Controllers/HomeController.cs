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

            public ViewResult Add(Exercise e)
        {
            //return (e.first + e.second + e.third).ToString();
            return View();
        }

        public ActionResult AddResult(Exercise e)
        {
            int result = e.first + e.second + e.third;
            ViewBag.First = e.first;

            ViewBag.Result = result;
            return View("Add");
        }

        //public string Add(int first = 0, int second = 0, int third = 0)
        //{
        //    return (first + second + third).ToString();
        //}

        public string Substract(int first, int second)
        {
            return (first - second).ToString();
        }

        public string Multiply(int first, int second)
        {
            return (first * second).ToString();
        }

        public string Divide(int first, int second)
        {
            if (second == 0)
                return "Cannot divide by zero";
            double dFirst = first;
            double dSecond = second;
            return (dFirst / dSecond).ToString();
        }

    }
}
