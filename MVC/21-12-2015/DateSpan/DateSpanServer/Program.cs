using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DateSpanServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ImpreciseService));
            host.Open();
            Console.WriteLine("Listening to Imprecise Date Differences");

            ServiceHost hostPrecise = new ServiceHost(typeof(PreciseService));
            hostPrecise.Open();
            Console.WriteLine("Listening to Precise Date Differences");
            Console.ReadLine();            
        }
    }
}
