using System.Collections.Generic;

namespace ef6.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }

        public List<Member> Members { get; set; }
    }
}