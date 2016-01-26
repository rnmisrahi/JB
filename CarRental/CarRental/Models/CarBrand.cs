using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRental.Models
{
    public class CarBrand
    {
        public int CarBrandId { get; set; }
        public string BrandName { get; set; }

        public virtual ICollection<CarModel> CarModels { get; set;}
    }
}