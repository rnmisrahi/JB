using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ef6Demo.Models
{
    public class MembersDBContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}