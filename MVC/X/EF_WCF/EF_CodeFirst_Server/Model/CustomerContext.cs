using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_Server.Model
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
