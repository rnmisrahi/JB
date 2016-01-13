using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {

        static List<Customer> customers = new List<Customer>
        {
            new Customer {LastName="Peters", Name="Ruben", State="OH" },
            new Customer {LastName="Eastern", Name="Lulu", State="OH" },
            new Customer {LastName="Smith", Name="John", State="NY" },
            new Customer {LastName="Johnson", Name="Steve", State="NJ" },
        };

        static void Main(string[] args)
        {
            IEnumerable<Customer> stateQuery =
                from cust in customers
                where cust.State == "OH"
                select cust;
            foreach(Customer c in stateQuery)
            {
                Console.WriteLine(c.LastName + " " + c.Name);
            }
            Console.ReadLine();
        }
    }
}
