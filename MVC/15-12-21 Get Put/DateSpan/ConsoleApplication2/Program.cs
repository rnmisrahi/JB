using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.ServiceReference1;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Parse("2003-11-4");
            ImpreciseServiceClient client = new ImpreciseServiceClient();
            int years = client.GetAge(date);
            Console.WriteLine("The guy born in {0:yyyy-MM-dd} is {1} years old", date, years);
            DateTime date2 = DateTime.Parse("2009-01-02");
            years = client.AgeDifference(date, date2);
            Console.WriteLine("The difference between {0:yyyy-MM-dd} and {1:yyyy-MM-dd} is {2} years", date, date2, years);
            Console.ReadLine();
        }
    }
}
