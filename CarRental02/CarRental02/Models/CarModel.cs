using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRental02.Models
{
    public class CarModel
    {
        public int CarModelId { get; set; }
        public int CarBrandId { get; set; }
        public string ModelName { get; set; }

        public virtual CarBrand CarBrand { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}