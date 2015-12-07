using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ajax5.Models
{
    public class Article
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArticleId { get; set; }
        [Required]
        [StringLength(90, ErrorMessage = "Headline between 5 and 90 characters")]
        public string Headline { get; set; }
        public string Content { get; set; }
    }
}