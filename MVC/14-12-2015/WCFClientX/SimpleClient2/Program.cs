using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using SimpleClient2.InventoryService;

namespace SimpleClient2
{
    class Program
    {

        private static void query()
        {

        }

        static void Main(string[] args)
        {
            IInventory service = ChannelFactory<IInventory>.CreateChannel(
                new BasicHttpBinding(),
                new EndpointAddress("http://localhost:920/mex"));

            //Console.WriteLine(service.GetMessage());
            Console.WriteLine("Enter name:");
            List<Item> items = new List<Item>();
            var name = Console.ReadLine();
            while (name != "quit")
            {
                try
                {
                    //items = service.GetItems();
                    string s = service.GetMessage();
                    Console.WriteLine("Message: " + s);

                    //int newQty = service.AddQuantity(1, 3);
                    //Console.WriteLine(string.Format("New Qty: {0}", newQty));

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
