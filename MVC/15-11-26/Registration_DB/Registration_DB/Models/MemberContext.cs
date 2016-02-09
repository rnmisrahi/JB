using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Registration_DB.Models
{
    public class MemberContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}