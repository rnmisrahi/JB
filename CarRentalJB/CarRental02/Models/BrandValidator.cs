using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace CarRental02.Models
{
    public class BrandValidator
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

        //public BrandValidator()
        //{
        //    RuleFor(x => x.BrandName).NotEmpty().WithMessage("Brand Name Cannot be Empty");
        //    RuleFor(x => x.BrandName).Must(BeUniqueBrand).WithMessage("Brand Already Exists");
        //}

        //private bool BeUniqueBrand(string name)
        //{
        //    var _db = new CarRentalContext();            
        //    return (_db.CarBrands.SingleOrDefault(x => x.BrandName == name) == null);
        //}
    }
}