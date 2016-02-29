using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using CarRental02.Models;

namespace CarRental02.ViewModels
{
    [ComplexType]
    public class ViewModelFactory
    {
        //private static CarRentalContext db = new CarRentalContext();

        public ViewModelFactory()
        {

        }

        #region CarModelViewModel
        public static CarModelViewModel CreateCarModelViewModel(CarModel carModel)
        {
            CarRentalContext db = new CarRentalContext();
            CarModelViewModel cmvm = new CarModelViewModel();
            cmvm.CarModelData = carModel;
            cmvm.Brands = new SelectList(db.CarBrands, "CarBrandId", "BrandName", cmvm.CarModelData.CarBrandId);
            return cmvm;
        }

        public static CarModelViewModel CreateCarModelViewModel()
        {
            return CreateCarModelViewModel(new CarModel());
        }

        public static CarModelViewModel CreateCarModelViewModel(int? id)
        {
            CarRentalContext db = new CarRentalContext();
            CarModel carModel = db.CarModels.Find(id);
            if (carModel != null)
            {
                return CreateCarModelViewModel(carModel);
            }
            return null;
        }
        #endregion

        
        public static CarTypeViewModel CreateCarTypeViewModel()
        {
            return CreateCarTypeViewModel(new CarType());
        }

        public static CarTypeViewModel CreateCarTypeViewModel(CarType carType)
        {
            CarRentalContext db = new CarRentalContext();
            CarTypeViewModel ectvm = new CarTypeViewModel();
            ectvm.CarTypeData = carType;
            ectvm.CarEdited = new Car();//Just to prevent it being null
            ectvm.CarModels = new SelectList(db.CarModels, "CarModelId", "Description", ectvm.CarTypeData.CarModelId);
            return ectvm;
        }

        public static CarTypeViewModel CreateCarTypeViewModel(int? id)
        {
            CarRentalContext db = new CarRentalContext();
            CarType carType = db.CarTypes.Find(id);
            if (carType != null)
            {
                return CreateCarTypeViewModel(carType);
            }
            return null;
        }

        public static CarViewModel CreateCarViewModel(Car car)
        {
            CarRentalContext db = new CarRentalContext();
            CarViewModel ecvm = new CarViewModel();
            ecvm.CarData = car;
            ecvm.Branches = new SelectList(db.Branches, "BranchId", "BranchName", car.BranchId);
            ecvm.CarTypes = new SelectList(db.CarTypes, "CarTypeId", "Description", car.CarTypeId);
            return ecvm;
        }

        public static CarViewModel CreateCarViewModel(int? id)
        {
            CarRentalContext db = new CarRentalContext();
            Car car = db.Cars.Find(id);
            if (car != null)
            {
                //There is some code that is executed twice, but it's worth considering we abide by the DRY principle
                return CreateCarViewModel(car);
            }
            return null; //todo return an error or make View return an error
        }

        public static CarViewModel CreateCarViewModel()
        {
            return CreateCarViewModel(new Car());
        }

    }


}