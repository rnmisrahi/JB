using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRental02.Models.Validators
{
    public class CityValidator:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            using (var _db = new ApplicationDbContext())
            {
                var city = validationContext.ObjectInstance as City;
                if (city == null) return new ValidationResult("City is empty");
                var c = _db.Cities.SingleOrDefault(x => x.CityName == (string)value && x.CityId!=city.CityId);
                if (c == null)
                    return ValidationResult.Success;
                return new ValidationResult(String.Format("{0} {1} Already Exists", "City", value));
            }
        }
    }
}