using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFServer.Model;

namespace WCFServer
{
    public class Inventory:IInventory
    {
        public string GetMessage()
        {
            return "Shalom client";
        }

        public int AddItem(String name, int quantity)
        {
            int nextId = InventoryContext.getNextId();
            Item item = new Item { ItemId=nextId, Name = name, Quantity = quantity };
            InventoryContext.Items.Add(item);
            return nextId;
        }

        public int AddQuantity(int itemId, int quantity)
        {
            Item item = InventoryContext.Items.FirstOrDefault(m => m.ItemId == itemId);
            item.Quantity += quantity;
            return quantity;
        }

        public int SubtractQuantity(int itemId, int quantity)
        {
            return AddQuantity(itemId, -quantity);
        }

        public List<Item> GetItems()
        {
            List<Item> items = new List<Item>();
            items = InventoryContext.Items;
            return items;
        }

    }
}
