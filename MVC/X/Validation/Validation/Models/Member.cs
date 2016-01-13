using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Validacion.Models
{
    public class Member
    {
        public int    MemberId   { get; set; }
        public string MemberName { get; set; }
        [Remote("CheckNickName", "Home")]
        public string NickName   { get; set; }
        public string Phone      { get; set; }
        public double Salary     { get; set; }
    }
}