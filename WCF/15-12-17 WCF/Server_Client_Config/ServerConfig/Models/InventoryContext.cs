using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerConfig.Models
{
    public class InventoryContext
    {
        public static List<Item> Items = new List<Item>
        {
            new Item {ItemId=1,ItemName="Bag",Quantity=20 },
            new Item {ItemId=2,ItemName="Chair",Quantity=8 },
            new Item {ItemId=3,ItemName="Table",Quantity=2 }
        };

        private static int mNextId = 3;
        public static int getNextId()
        {
            mNextId++;
            return mNextId;
        }

    }
}
