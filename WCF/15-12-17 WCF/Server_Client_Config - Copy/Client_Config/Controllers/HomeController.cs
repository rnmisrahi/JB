using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Client_Config.InventoryServices;
using Client_Config.Models;

namespace Client_Config.Controllers
{ 
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            InventoryServices.InventoryClient client = new InventoryServices.InventoryClient();
            var items = client.GetItems();
            return View(items);
        }

        public ActionResult Details(int id)
        {
            InventoryServices.InventoryClient client = new InventoryServices.InventoryClient();
            var item = client.GetItems().FirstOrDefault(m => m.ItemId == id);
            return View(item);
        }

        public ActionResult Edit(int id)
        {
            InventoryServices.InventoryClient client = new InventoryServices.InventoryClient();
            var item = client.GetItems().FirstOrDefault(m => m.ItemId == id);
            return View(item);
        }

        [HttpPost]
        public ActionResult AddQuantity(ItemAdded itemAdded)
        {
            InventoryClient client = new InventoryClient();
            client.AddQuantity(itemAdded.Item.ItemId, itemAdded.QuantityAdded);
            return RedirectToAction("Index");
        }

        public ActionResult AddQuantity(int Id)
        {
            InventoryClient client = new InventoryClient();
            var item = client.GetItems().FirstOrDefault(m => m.ItemId == Id);
            ItemAdded itemAdded = new ItemAdded();
            itemAdded.Item = client.GetItems().FirstOrDefault(m => m.ItemId == Id);
            itemAdded.QuantityAdded = 0;
            return View(itemAdded);
        }

        [HttpPost]
        public ActionResult Edit(Item item)
        {
            return null;
        }

        public ActionResult Create()
        {
            InventoryClient client = new InventoryClient();
            return View(new Item());
        }

        [HttpPost]
        public ActionResult Create(Item item)
        {
            InventoryClient client = new InventoryClient();
            client.AddItem(item.ItemName, item.Quantity);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            InventoryClient client = new InventoryClient();
            client.RemoveItem(Id);
            return RedirectToAction("Index");
        }

        public ActionResult Plus1(int Id)
        {
            InventoryClient client = new InventoryClient();
            client.AddQuantity(Id, 1);
            return RedirectToAction("Index");
        }

        public ActionResult Minus1(int Id)
        {
            InventoryClient client = new InventoryClient();
            client.SubtractQuantity(Id, 1);
            return RedirectToAction("Index");
        }

    }
}