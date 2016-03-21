using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarRental02.Models.Validators
{
    public class BrandNameValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            using (var _db = new ApplicationDbContext())
            {
                var carBrand = validationContext.ObjectInstance as CarBrand;
                if (carBrand == null) return new ValidationResult("Car Brand is empty");
                var c = _db.CarBrands.SingleOrDefault(x => x.BrandName == (string)value && x.CarBrandId != carBrand.CarBrandId);
                if (c == null)
                    return ValidationResult.Success;
                return new ValidationResult(String.Format("{0} {1} Already Exists", "Car Brand", value));
            }
        }
    }
}