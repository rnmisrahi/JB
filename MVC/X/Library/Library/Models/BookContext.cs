using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Library.Models
{
    public class BookContext:DbContext
    {
        DbSet<Book> Books { get; set; }
    }
}