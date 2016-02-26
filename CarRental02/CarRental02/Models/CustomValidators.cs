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
            if (String.IsNullOrWhiteSpace(brandName))
                return new ValidationResult("Brand Name Cannot be Empty");
            using (var _db = new CarRentalContext())
            {
                if (_db.CarBrands.SingleOrDefault(x => x.BrandName == brandName) == null)
                    return ValidationResult.Success;
                return new ValidationResult("Brand " + brandName + " Already Exists");
            }
        }

        public static ValidationResult ValidateModel(string modelName)
        {
            if (String.IsNullOrWhiteSpace(modelName))
                return new ValidationResult("Model Name Cannot be Empty");
            using (var _db = new CarRentalContext())
            {
                if (_db.CarModels.SingleOrDefault(x => x.ModelName == modelName) == null)
                    return ValidationResult.Success;
                return new ValidationResult("Model " + modelName + " Already Exists");
            }
        }
    }
}