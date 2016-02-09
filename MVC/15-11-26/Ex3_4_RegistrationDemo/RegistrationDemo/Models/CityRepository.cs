using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationDemo.Models
{
    public static class CityRepository
    {
        public static List<City> Cities = new List<City>
        {
            new City { CityId=3000, CityName = "Jerusalem" },
            new City { CityId=4000, CityName = "Haifa" },
            new City { CityId=5000, CityName = "Tel Aviv" },
            new City { CityId=7000, CityName = "Lod" },
        };
    }
}