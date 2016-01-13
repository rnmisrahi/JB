using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ef6.Models
{
    public class MemberDbContext:DbContext
    {
        public DbSet<Member> Member { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}