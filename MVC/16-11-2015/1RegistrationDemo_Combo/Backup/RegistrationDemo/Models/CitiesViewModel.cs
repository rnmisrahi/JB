using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationDemo.Models
{
    public class CitiesViewModel
    {
        public List<City> cities { get; set; }

        public CitiesViewModel()
        {
            cities = new List<City>();
        }
    }
}