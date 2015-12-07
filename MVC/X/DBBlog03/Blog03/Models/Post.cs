using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog03.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}