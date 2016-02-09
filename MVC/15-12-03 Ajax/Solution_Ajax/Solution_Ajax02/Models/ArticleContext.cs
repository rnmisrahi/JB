using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Solution_Ajax02.Models
{
    public class ArticleContext:DbContext
    {
        public DbSet<Article> Articles { get; set; }
    }
}