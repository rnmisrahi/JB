using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRental02.Models
{
    public class EditCarTypeViewModel
    {
        public CarType CarTypeData { get; set; }
        public List<CarModel> CarModels { get; set; }
    }
}