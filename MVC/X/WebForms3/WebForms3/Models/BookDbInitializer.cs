using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebForms3.Models
{
    public class BookDbInitializer:DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            base.Seed(context);
        }


    }
}