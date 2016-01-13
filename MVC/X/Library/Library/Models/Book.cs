using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        [MaxLength(6)]
        public string BookId { get; set; }
        public string Title { get; set; }
        public string Editor { get; set; }
        public string Audience { get; set; }
        public string Category { get; set; }
        public int Copies { get; set; }
        public bool IsActive { get; set; }
    }
}