using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registration01.Models
{
    public partial class Voter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public bool IsRegistered { get; set; }
        public bool HasCookies { get; set; }
    }
}