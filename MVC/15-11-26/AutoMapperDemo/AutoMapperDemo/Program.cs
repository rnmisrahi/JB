using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book
            {
                BookID = 123123,
                BookName = "Ali Baba",
                Price = 73.63,
                InnerCode = 767,
                Stat = new Statistics { S1 = 565, S2 = 676, }
            };
            Mapper.CreateMap<Book, BookVM>();
            //BookVM bookvm=new BookVM();
            //Mapper.Map(book, bookvm);
            var bookvm = Mapper.Map<BookVM>(book);
            Console.WriteLine(bookvm);
            Console.WriteLine(book.Stat.Equals(bookvm.Stat));
            Console.WriteLine(object.ReferenceEquals(book.Stat, bookvm.Stat));
            Console.ReadLine();
        }
    }
}
