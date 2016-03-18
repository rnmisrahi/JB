using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarRental02.Models.Validators
{
    public class CarCodeValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            using (var _db = new CarRentalContext())
            {
                var carType = validationContext.ObjectInstance as CarType;
                if (carType == null) return new ValidationResult("Car Code is empty");
                var c = _db.CarTypes.SingleOrDefault(x => x.CarCode == (string)value && x.CarTypeId != carType.CarTypeId);
                if (c == null)
                    return ValidationResult.Success;
                return new ValidationResult(String.Format("{0} {1} Already Exists", "Car Code", value));
            }
        }
    }
}