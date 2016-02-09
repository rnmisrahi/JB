using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Citizens_and_Cars.Models
{
    public class Citizen
    {
        public int CitizenId { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }

        public List<Car> Cars { get; set; }
    }
}