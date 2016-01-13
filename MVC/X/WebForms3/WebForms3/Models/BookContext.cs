using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebForms3.Models
{
    public class BookContext:DbContext
    {
        public BookContext():base("EIWebForms3")
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}