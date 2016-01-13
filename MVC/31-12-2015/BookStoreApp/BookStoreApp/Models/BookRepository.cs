using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApp.Models
{
    public static class BookRepository
    {
        private static List<Book> Books { get; set; }


        static BookRepository()
        {
            Books = new List<Book>
            {
                new Book {BookCode="aa11a", BookName="Red Hat" },
                new Book {BookCode="bb22bb", BookName="Alibaba" },
                new Book {BookCode="cc33cc", BookName="All my sons" },
            };
            
        }
        public static void Add(Book book)
        {
            Books.Add(book);
        }

        public static IEnumerable<Book> GetAll()
        {
            return Books;
        }

    }
}