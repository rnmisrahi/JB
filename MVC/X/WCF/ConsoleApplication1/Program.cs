using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Currency));
            host.AddServiceEndpoint(
                typeof(ICurrency),
                
                new BasicHttpBinding(),
                "http://localhost:910/Stosvc");
        }
    }
}
