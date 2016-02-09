using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ef6Demo.Models
{
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }

        public List<Member> Members { get; set; }
    }
}