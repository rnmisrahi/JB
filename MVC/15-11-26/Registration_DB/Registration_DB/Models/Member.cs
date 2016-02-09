using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Registration_DB.Models
{
    public class Member
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public int Seniority { get; set; }
    }
}