using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost simpleHost = new ServiceHost(typeof(SimpleBirthService));
            simpleHost.Open();
            ServiceHost exactHost = new ServiceHost(typeof(ExactBirthService));
            exactHost.Open();

            Console.WriteLine("Server is running...");
            Console.ReadLine();
        }
    }
}
