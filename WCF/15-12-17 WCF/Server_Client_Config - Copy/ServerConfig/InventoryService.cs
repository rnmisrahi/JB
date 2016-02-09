using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServerConfig.Models;

namespace ServerConfig
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "InventoryService" in both code and config file together.
    public class InventoryService : IInventoryService
    {
        public List<Item> GetItems()
        {
            List<Item> items = new List<Item>();
            items = ItemRepository.items;
            return items;

            //Models.InventoryContext.
        }
    }
}
