using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerConfig.Models
{
    public static class ItemRepository
    {
        public static List<Item> items = new List<Item>
        {
            new Item {ItemId=1, ItemName="Table", Quantity=23 },
            new Item {ItemId=2,ItemName="Chair",Quantity =73 },
            new Item {ItemId=3,ItemName="Lamp",Quantity=53 }
        };
    }
}
