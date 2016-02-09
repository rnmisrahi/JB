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
            Console.Title = "Calculator Server";

            try
            {
                using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
                {
                    host.Open();
                    Console.WriteLine("Server is running...");
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            
            
        }
    }
}
