﻿using System;
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

        public string Add(int first, int second)
        {
            return (first+second).ToString();
        }

    }
}
