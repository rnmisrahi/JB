using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CodeFirst_Server.Model;

namespace EF_CodeFirst_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            using(CustomerContext db = new CustomerContext())
            {
                Console.Write("Enter Name:");
                var name = Console.ReadLine();
                Customer customer = new Customer{ CustomerName=name};
                db.Customers.Add(customer);
                db.SaveChanges();
                var query = from b in db.Customers
                            select b;
                foreach (var c in query)
                {
                    Console.WriteLine("{0} - {1} - {2}", c.CustomerId, c.CustomerName, c.Phone);
                }

            }
        }
    }
}
