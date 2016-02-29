using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarRental02.Models
{
    public enum Gear
    {
        Automatic, Shift
    }

    public class CarType
    {
        public int CarTypeId { get; set; }
        private CarRentalContext db = new CarRentalContext();

        [Display(Name ="Car Code")]
        public string CarCode { get; set; }

        [Required]
        [Display(Name ="Model")]
        public int CarModelId { get; set; }

        [Display(Name ="$/Day")]
        public double DailyPrice { get; set; }
        [Display(Name ="$/Day Late")]
        public double DailyLatePrice { get; set; }
        public Gear? Gear { get; set; }
        [NotMapped]
        [Display(Name = "Brand-Model")]
        public string Description {
            get
            {
                var aModel = db.CarModels.Find(CarModelId);
                return string.Format("Code: {0} - Brand: {1} - Model:{2}", CarCode, aModel.CarBrand.BrandName, 
                    aModel.ModelName);
            }
        }

        public virtual CarModel CarModel { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}