using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarRental02.Models
{
    public class CustomValidators
    {
        //All these worked when adding a record, but not when editing, because it would
        //  find the record as "Already existing." So we could not save when making changes
        //  to other fields.
        //I had to add a class in the Validators folder for each validation. That did work ok
        private static ValidationResult alreadyExists(object obj, string fieldName, string fieldValue) {
            if (obj == null)
                return ValidationResult.Success;
            return new ValidationResult(String.Format("{0} {1} Already Exists", fieldName, fieldValue));
        }

        public static ValidationResult ValidateCity(string city)
        {
            using (var _db = new CarRentalContext())
            {
                return alreadyExists(_db.Cities.SingleOrDefault(x => x.CityName == city), "City", city);
            }
        }

        public static ValidationResult ValidateCarCode(string carCode)
        {
            using (var _db = new CarRentalContext())
            {
                return alreadyExists(_db.CarTypes.SingleOrDefault(x => x.CarCode == carCode), "Car Code", carCode);
            }
        }

        public static ValidationResult ValidateBrandName(string brandName)
        {
            using (var _db = new CarRentalContext())
            {
                return alreadyExists(_db.CarBrands.SingleOrDefault(x => x.BrandName == brandName), "Brand", brandName);
                //if (_db.CarBrands.SingleOrDefault(x => x.BrandName == brandName) == null)
                //    return ValidationResult.Success;
                //return new ValidationResult(String.Format("Brand " + brandName + " Already Exists"));
            }
        }

        public static ValidationResult ValidateModel(string modelName)
        {
            using (var _db = new CarRentalContext())
            {
                return alreadyExists(_db.CarModels.SingleOrDefault(x => x.ModelName == modelName), "Model", modelName);
                //if (_db.CarModels.SingleOrDefault(x => x.ModelName == modelName) == null)
                //    return ValidationResult.Success;
                //return new ValidationResult("Model " + modelName + " Already Exists");
            }
        }
    }
}