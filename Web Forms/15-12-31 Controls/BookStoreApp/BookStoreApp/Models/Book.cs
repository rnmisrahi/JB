using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApp.Models
{
    public class Book
    {
        public string BookCode { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int TargetGroup { get; set; }
        public int Category { get; set; }
        public bool IsActive { get; set; }
    }
}