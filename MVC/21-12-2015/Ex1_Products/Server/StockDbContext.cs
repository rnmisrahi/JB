using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class StockDbContext : DbContext
    {
        public StockDbContext()
        {
            Configuration.ProxyCreationEnabled = true;
        }

        public DbSet<Product> Products { get; set; }
    }
}
