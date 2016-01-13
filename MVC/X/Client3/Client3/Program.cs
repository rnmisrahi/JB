using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client3.MyService;

namespace Client3
{
    class Program
    {
        static void Main(string[] args)
        {
            Client3.MyService.InventoryClient service = new InventoryClient();

            Console.WriteLine(service.GetMessage());
            Console.WriteLine("Enter name:");
            var name = Console.ReadLine();
            Item[] items;
            while (name != "quit")
            {
                try
                {
                    string s = service.GetMessage();
                    Console.WriteLine(string.Format("message: {0}", s));
                    int n = service.AddItem(name, 5);
                    items = service.GetItems();
                    foreach(Item item in items)
                    {
                        Console.WriteLine("Item: {0}. Qty: {1}", item.Name, item.Quantity);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
            }

        }
    }
}
