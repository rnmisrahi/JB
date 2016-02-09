using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationDemo.Models
{
    public class CustomValidators
    {
        private static bool Underage(DateTime dateTime, int age)
        {
            DateTime dt = dateTime.AddYears(age);
            int res = DateTime.Compare(dt, DateTime.Now);
            return res > 0;
        }

        private static bool Overage(DateTime dateTime, int age)
        {
            DateTime dt = dateTime.AddYears(age);
            int res = DateTime.Compare(dt, DateTime.Now);
            return res < 0;
        }

        public static ValidationResult IsValidBirthDate(DateTime value)
        {
            if ((value.Year < 1800) || (value.Year > 2500))
                return new ValidationResult("Invalid Date");
            if (Underage(value, 18))
                return new ValidationResult("You are too young. Try tomorrow!");
            if (Overage(value, 100))
                return new ValidationResult("You are too old. Have you great-grandsons??");

            return ValidationResult.Success;
        }

        public static ValidationResult IsValidSeniority(int seniority)
        {
            //Todo when we know how to include parameters from other fields

            return ValidationResult.Success;
        }
    }
}