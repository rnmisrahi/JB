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
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(StockService));
            host.AddServiceEndpoint(typeof(IStockService),
                                    new BasicHttpBinding(),
                                    "http://localhost:923/ProdSvc");

            ServiceMetadataBehavior metadataBehavior = new ServiceMetadataBehavior();
            metadataBehavior.HttpGetEnabled = true;
            metadataBehavior.HttpGetUrl = new Uri("http://localhost:924/ProdSvc/mex");
            host.Description.Behaviors.Add(metadataBehavior);

            host.AddServiceEndpoint(
                typeof(IMetadataExchange),
                new BasicHttpBinding(),
                "http://localhost:924/ProdSvc/mex");
            host.Open();

            Console.WriteLine("Started!");
            Console.ReadLine();
        }
    }
}
