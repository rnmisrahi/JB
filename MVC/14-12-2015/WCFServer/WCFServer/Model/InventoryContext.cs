using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFServer.Model;

namespace WCFServer.Model
{
    public class InventoryContext
    {
        public static List<Item> Items = new List<Item>
        {
            new Item {ItemId=1,Name="Bag",Quantity=20 },
            new Item {ItemId=2,Name="Chair",Quantity=8 },
            new Item {ItemId=3,Name="Table",Quantity=2 }
        };

        private static int mNextId = 4;
        public static int getNextId()
        {
            mNextId++;
            return mNextId;
        }

    }
}
