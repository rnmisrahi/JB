using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blog03.Models
{
    public class Blog03Context:DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        //public DbSet<Post> Posts { get; set; }
    }
}