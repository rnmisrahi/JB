using CarRental02.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRental02.ViewModels
{
    [NotMapped]
    public class CarModelVM
    {
        public CarModel CarModel { get; set; }
        public SelectList brandList { get; set; }

        public CarModelVM()
        {
            //For some reason we have to have a zero-parameter constructor
        }

        public CarModelVM(CarModel carModelData, IEnumerable brandList)
        {
            this.CarModel = carModelData;
            this.brandList = new SelectList(brandList, "CarBrandId", "BrandName", carModelData.CarBrandId);
        }

    }
}