using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperDemo
{
    class BookVM
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public double Price { get; set; }
        public Statistics Stat { get; set; }
        public double Vat 
        {
            get
            {
                return Price * 0.17;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} --- {1} --- {2} --- {3}", BookID, BookName, Price, Vat);
        }
    }
}
