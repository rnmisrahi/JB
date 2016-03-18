using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarRental02.Models.Validators
{
    public class CarModelNameValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            using (var _db = new CarRentalContext())
            {
                var carModel = validationContext.ObjectInstance as CarModel;
                if (carModel == null) return new ValidationResult("Car Model is empty");
                var c = _db.CarModels.SingleOrDefault(x => x.ModelName == (string)value && x.CarModelId != carModel.CarModelId);
                if (c == null)
                    return ValidationResult.Success;
                return new ValidationResult(String.Format("{0} {1} Already Exists", "Car Model", value));
            }
        }
    }
}