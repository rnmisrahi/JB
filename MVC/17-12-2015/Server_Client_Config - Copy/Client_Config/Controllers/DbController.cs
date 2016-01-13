using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Client_Config.Models;
using Client_Config.InventoryServices;

namespace Client_Config.Controllers
{
    public class DbController : Controller
    {   
        public ActionResult Index()
        {
            InventoryServices.InventoryClient client = new InventoryServices.InventoryClient();
            var items = client.DbGetItems();
            return View(items);
        }

        //public ActionResult Delete(int id)
        //{
        //    InventoryClient client = new InventoryClient();
        //    client.DbRemoveItem(id);
        //    return null;
        //}

        public ActionResult DeleteItems()
        {
            //return RedirectToAction("Delete");
            InventoryClient db = new InventoryClient();
            db.DbClearItems();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            InventoryServices.InventoryClient client = new InventoryServices.InventoryClient();
            var item = client.DbGetItems().FirstOrDefault(m => m.ItemId == id);
            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(Item item)
        {
            InventoryClient client = new InventoryClient();
            client.DbSaveItem(item);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            InventoryServices.InventoryClient client = new InventoryServices.InventoryClient();
            var item = client.DbGetItem(id);
            return View(item);
        }

        [HttpPost]
        public ActionResult AddQuantity(ItemAdded itemAdded)
        {
            InventoryClient client = new InventoryClient();
            client.DbAddQuantity(itemAdded.Item.ItemId, itemAdded.QuantityAdded);
            
            return RedirectToAction("Index");
        }

        public ActionResult AddQuantity(int Id)
        {
            InventoryClient client = new InventoryClient();
            //Todo: Add to the server a more efficient way to get a specific item based on ItemId
            //var item = client.DbGetItems().FirstOrDefault(m => m.ItemId == Id);
            ItemAdded itemAdded = new ItemAdded();
            itemAdded.Item = client.DbGetItems().FirstOrDefault(m => m.ItemId == Id);
            itemAdded.QuantityAdded = 0;
            return View(itemAdded);
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
            client.DbAddItem(item.ItemName, item.Quantity);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(Item item)
        {
            InventoryClient client = new InventoryClient();
            client.DbRemoveItem(item.ItemId);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            InventoryClient client = new InventoryClient();
            var item = client.DbGetItem(Id);
            return View(item);
        }

        public ActionResult Plus1(int Id)
        {
            InventoryClient client = new InventoryClient();
            client.DbAddQuantity(Id, 1);
            return RedirectToAction("Index");
        }

        public ActionResult Minus1(int Id)
        {
            InventoryClient client = new InventoryClient();
            client.DbSubtractQuantity(Id, 1);
            return RedirectToAction("Index");
        }
    }
}