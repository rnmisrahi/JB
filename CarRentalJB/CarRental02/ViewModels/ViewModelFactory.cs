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

        #region CarTypeViewModel
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
        #endregion

        #region CarViewModel
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
        #endregion

        #region SearchCarViewModel
        public static SearchCarViewModel CreateSearchCarViewModel(Car car)
        {
            CarRentalContext db = new CarRentalContext();
            SearchCarViewModel scvm = new SearchCarViewModel();
            CarType carType;
            Branch branch;

            scvm.CarData = car;

            carType = db.CarTypes.Find(car.CarTypeId);
            //if (carType != null)
            //    scvm.CarCode = carType.CarCode;
            //else
            //    scvm.CarCode = "";

            //branch = db.Branches.Find(car.BranchId);
            //if (branch != null)
            //{
            //    scvm.Branch = branch.City + " - " + branch.BranchName;
            //}

            return scvm;
        }

        public static SearchCarViewModel CreateSearchCarViewModel()
        {
            return CreateSearchCarViewModel(new Car());
        }
        #endregion

        #region BrandViewModel Experimental
        public static BrandViewModel CreateBrandViewModel(CarBrand brand, string displayMode)
        {
            BrandViewModel model = new BrandViewModel();
            model.DisplayMode = displayMode;
            using (CarRentalContext db = new CarRentalContext())
            {
                model.Brands = db.CarBrands.ToList();
                model.SelectedBrand = brand;
            }
            return model;
        }

        public static BrandViewModel CreateBrandViewModel(int id, string displayMode)
        {
            using (CarRentalContext db = new CarRentalContext())
            {
                CarBrand brand = db.CarBrands.Find(id);
                return CreateBrandViewModel(brand, displayMode);
            }

        }


        #endregion
    }


}