using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IStockService service = ChannelFactory<IStockService>.CreateChannel(
                new BasicHttpBinding(),
                new EndpointAddress("http://localhost:910/Stosvc"));

            Console.WriteLine(service.GetMessage());
            Console.WriteLine("Enter name:");
            var name = Console.ReadLine();
            while (name != "quit")
            {
                try
                {
                    double price=service.GetPrice(name);
                    Console.WriteLine(string.Format("Price: {0}", price));
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
