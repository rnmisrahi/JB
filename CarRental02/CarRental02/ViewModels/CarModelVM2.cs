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
    public class CarModelVM2
    {
        public int CarModelVM2Id { get; set; }
        public CarModel CarModel { get; set; }
        public SelectList BrandList { get; private set; }

        public CarModelVM2()
        {
            Console.WriteLine("Who called us");
        }

        public CarModelVM2(CarModel carModelData, IEnumerable brandList)
        {
            CarModel = carModelData;
            CarModelVM2Id = carModelData.CarModelId;
            BrandList = new SelectList(brandList, "CarBrandId", "BrandName", carModelData.CarBrandId);
        }
    }
}