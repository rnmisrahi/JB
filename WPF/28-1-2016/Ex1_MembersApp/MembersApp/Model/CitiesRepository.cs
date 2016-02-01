using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersApp.Model
{
    public static class CitiesRepository
    {
        private static List<City> Cities;

        static CitiesRepository()
        {
            Cities = new List<City>
            {
                new City {CityID=3000, CityName="Jerusalem",},
                new City {CityID=4000, CityName="Haifa",},
                new City {CityID=5000, CityName="Tel aviv",},
                new City {CityID=6000, CityName="Baka",},
                new City {CityID=7000, CityName="Beer sheva",},
                new City {CityID=8000, CityName="Zefat",},
            };
        }

        public static string GetName(int cityID) 
        {
            City city=Cities.FirstOrDefault(c => c.CityID == cityID);
            if (city != null)
                return city.CityName;
            return null;
        }

        public static int GetId(string cityName) {
            City city=Cities.FirstOrDefault(c => c.CityName == cityName);
            if (city != null)
                return city.CityID;
            return 0;
        }
    }
}
