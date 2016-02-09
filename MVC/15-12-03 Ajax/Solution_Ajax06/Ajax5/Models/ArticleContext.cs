using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ajax5.Models
{
    public class ArticleContext:DbContext
    {
        public DbSet<Article> Articles { get; set; }
    }
}