using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NwService" in both code and config file together.
    public class NwService : INwService
    {
        public List<Customer> GetAllCustomers()
        {
            NorthwindEntities context = new NorthwindEntities();
            return context.Customers.ToList();
        }

        public Customer GetCustomer(string customerID)
        {
            NorthwindEntities context = new NorthwindEntities();
            Customer customer = context.Customers.FirstOrDefault(
                c => c.CustomerID == customerID);
            return customer;
        }
    }
}
