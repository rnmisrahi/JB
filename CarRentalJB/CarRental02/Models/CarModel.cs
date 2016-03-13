using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Attributes;

namespace CarRental02.Models
{
    [Validator(typeof(CustomValidators))]
    public class CarModel
    {
        public int CarModelId { get; set; }
        private int mCarBrandId;
        [Display(Name ="Brand")]
        public int CarBrandId {
            get { return mCarBrandId; }
            set { mCarBrandId = value; }
        }
        [Display(Name = "Model")]
        [CustomValidation(typeof(CustomValidators), "ValidateModel")]
        [Required(ErrorMessage = "Model Name is Required")]
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