using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRental02.Models
{
    public class CustomValidators
    {

        public static ValidationResult ValidateBrandName(string brandName)
        {
            using (var _db = new CarRentalContext())
            {
                if (_db.CarBrands.SingleOrDefault(x => x.BrandName == brandName) == null)
                    return ValidationResult.Success;
                return new ValidationResult("Brand " + brandName + " Already Exists");
            }
        }

        public static ValidationResult ValidateModel(string modelName)
        {
            using (var _db = new CarRentalContext())
            {
                if (_db.CarModels.SingleOrDefault(x => x.ModelName == modelName) == null)
                    return ValidationResult.Success;
                return new ValidationResult("Model " + modelName + " Already Exists");
            }
        }
    }
}