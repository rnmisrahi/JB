using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace WCFServer
{
    class Program
    {
        private static void listen()
        {
            ServiceHost host = new ServiceHost(typeof(Inventory));
            host.AddServiceEndpoint(
                typeof(IInventory),
                new BasicHttpBinding(),
                "http://localhost:920/Inventory");

            ServiceMetadataBehavior metadataBehavior = new ServiceMetadataBehavior();
            metadataBehavior.HttpGetEnabled = true;
            metadataBehavior.HttpGetUrl = new Uri("http://localhost:920/mex");
            host.Description.Behaviors.Add(metadataBehavior);

            host.AddServiceEndpoint(
                typeof(IMetadataExchange),
                new BasicHttpBinding(),
                "http://localhost:920/mex");


            host.Open();

            Console.WriteLine("Started");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            listen();
        }
    }
}
