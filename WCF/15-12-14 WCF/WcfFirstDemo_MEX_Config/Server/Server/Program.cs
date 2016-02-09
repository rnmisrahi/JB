using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {

        private static void listen()
        {
            using (ServiceHost host = new ServiceHost(typeof(StockServiceConfig)))
            {
                host.Open();
                Console.WriteLine("Listening...");
                Console.ReadLine();
            }

            //using (ServiceHost host = new ServiceHost(typeof(StockService)))
            //{
            //    host.AddServiceEndpoint(
            //        typeof(IStockService),
            //        new BasicHttpBinding(),
            //        "http://localhost:910/Stosvc");

            //    ServiceMetadataBehavior metadataBehavior = new ServiceMetadataBehavior();
            //    metadataBehavior.HttpGetEnabled = true;
            //    metadataBehavior.HttpGetUrl = new Uri("http://localhost:910/mex");
            //    host.Description.Behaviors.Add(metadataBehavior);

            //    host.AddServiceEndpoint(
            //        typeof(IMetadataExchange),
            //        new BasicHttpBinding(),
            //        "http://localhost:910/mex");

            //    host.Open();

            //    Console.WriteLine("Started");
            //    Console.ReadLine();
            //}
        }

        static void Main(string[] args)
        {
            listen();
        }
    }
}
