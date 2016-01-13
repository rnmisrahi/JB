using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Wcf_EI_Polymorphism_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost service = new ServiceHost(typeof(PersonService));
            service.Open();
            Console.WriteLine("Waiting for PersonService...");

            ServiceHost stamService = new ServiceHost(typeof(StamService));
            stamService.Open();
            Console.WriteLine("Waiting also for StamService...");
            Console.ReadLine();
        }
    }
}
