using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcClientValidation.Models
{
    public class Member
    {
        [Required]
        public int MemberID { get; set; }
        [StringLength(10, MinimumLength =2)]
        public string MemberName { get; set; }

        [Remote("CheckNicname", "Home", AdditionalFields = "Amount")]
        public string Nicname { get; set; }
        public int Amount { get; set; }
    }
}