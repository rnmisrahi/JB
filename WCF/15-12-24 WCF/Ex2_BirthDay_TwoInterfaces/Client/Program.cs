using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Birth;

namespace Client
{
    class Program
    {
        public static object SimpleServiceClient { get; private set; }

        static void Main(string[] args)
        {
            

            SimpleBirthServiceClient simple = new  SimpleBirthServiceClient();
            Console.WriteLine(simple.GetAgeSimple(DateTime.Parse("28/12/1980")));
            Console.WriteLine(simple.GetDifferenceSimple(DateTime.Parse("7/3/1990"), DateTime.Parse("11/3/1980")));


            ExactBirthServiceClient exact = new ExactBirthServiceClient();
            Console.WriteLine(exact.GetAgeExact(DateTime.Parse("28/12/1980")));
            Console.WriteLine(exact.GetDifferenceExact(DateTime.Parse("7/3/1990"), DateTime.Parse("11/3/1980")));

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
