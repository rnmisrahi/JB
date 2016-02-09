using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Details(string Id)
        {
            ItemViewModel ivm = ViewModelFactory.CreateItemViewModel(Id);
            return View("Details2", ivm);//Just to show that we can display a View with a different name
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            ItemViewModel ivm = ViewModelFactory.CreateItemViewModel(id);
            return View(ivm);
        }

        [HttpPost]
        public ActionResult Edit(ItemViewModel ivm)
        {
            if (ivm.ItemData.saveChangedItem())
                return RedirectToAction("ItemList");
            return null;
        }

        public ActionResult ItemList()
        {
            return View(Models.ViewModelFactory.CreateItemListViewModel());
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