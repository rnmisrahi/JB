using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperDemo
{
    class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public double Price { get; set; }
        public int InnerCode { get; set; }
        public Statistics Stat { get; set; }

        public override string ToString()
        {
            return string.Format("{0} --- {1} --- {2} --- {3}", BookID,BookName,Price, InnerCode);
        }
    }
}
