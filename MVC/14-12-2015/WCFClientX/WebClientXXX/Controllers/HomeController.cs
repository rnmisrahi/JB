﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClientXXX.InventoryService;

namespace WebClientXXX.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Inventory()
        {
            InventoryClient client = new InventoryClient();
            Item[] items = client.GetItems();
            return View(items);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}