using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarRental02.Models
{
    public class CarModel
    {
        public int CarModelId { get; set; }
        [Display(Name ="Brand")]
        public int CarBrandId { get; set; }
        [Display(Name = "Model")]
        public string ModelName { get; set; }

        [Display(Name = "Brand-Model")]
        public string Description {
            get
            {
                var db = new CarRentalContext();
                var brand = db.CarBrands.Find(CarBrandId);
                return string.Format("{0} - {1}", brand.BrandName, ModelName);
            }
        }

        public virtual CarBrand CarBrand { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}