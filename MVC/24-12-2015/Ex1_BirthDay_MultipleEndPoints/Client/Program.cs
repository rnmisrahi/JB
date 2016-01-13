using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        public static object SimpleServiceClient { get; private set; }

        static void Main(string[] args)
        {
            SimpleService.BirthServiceClient simple = new SimpleService.BirthServiceClient();
            Console.WriteLine(simple.GetAge(DateTime.Parse("28/12/1980")));
            Console.WriteLine(simple.GetDifference(DateTime.Parse("7/3/1990"), DateTime.Parse("11/3/1980")));


            ExactService.BirthServiceClient exact = new ExactService.BirthServiceClient();
            Console.WriteLine(exact.GetAge(DateTime.Parse("28/12/1980")));
            Console.WriteLine(exact.GetDifference(DateTime.Parse("7/3/1990"), DateTime.Parse("11/3/1980")));

            // DateTime d = DateTime.Parse("12/31/1980");
            // Console.WriteLine(d.Month);

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
