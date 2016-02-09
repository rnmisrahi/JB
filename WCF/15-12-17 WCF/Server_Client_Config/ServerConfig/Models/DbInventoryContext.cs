using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ServerConfig.Models
{
    public class DbInventoryContext:DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}
