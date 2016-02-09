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
            host.Open();

            Console.WriteLine("Started!");
            Console.ReadLine();
        }
    }
}
