using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryServices.InventoryServiceClient client = new InventoryServices.InventoryServiceClient();
            Console.WriteLine("Press Enter");
            Console.ReadLine();
            List<InventoryServices.Item> items = client.GetItems().ToList();
            foreach(InventoryServices.Item item in items)
            {
                Console.WriteLine("Item Id: {0}. Name: {1}. Quantity: {2} ", item.ItemId, item.ItemName, item.Quantity);
            }
            Console.ReadLine();
        }
    }
}
