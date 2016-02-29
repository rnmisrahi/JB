using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace CarRental02.Models
{
    [ComplexType]
    public class ViewModelFactory
    {
        //private static CarRentalContext db = new CarRentalContext();

        public ViewModelFactory()
        {

        }

        public static EditCarTypeViewModel CreateEditCarTypeViewModel()
        {
            CarType carType = new CarType();
            if (carType != null)
            {
                return createEditCarTypeVM(carType);
            }
            return null;

        }

        private static EditCarTypeViewModel createEditCarTypeVM(CarType carType)
        {
            CarRentalContext db = new CarRentalContext();
            EditCarTypeViewModel ectvm = new EditCarTypeViewModel();
            ectvm.CarTypeData = carType;
            ectvm.CarEdited = new Car();//Just to prevent it being null
            ectvm.CarModels = new SelectList(db.CarModels, "CarModelId", "Description", ectvm.CarTypeData.CarModelId);
            return ectvm;
        }

        public static EditCarTypeViewModel CreateEditCarTypeViewModel(int? id)
        {
            CarRentalContext db = new CarRentalContext();
            CarType carType = db.CarTypes.Find(id);
            if (carType != null)
            {
                return createEditCarTypeVM(carType);
            }
            return null;
        }

        private static EditCarViewModel createVM(Car car)
        {
            CarRentalContext db = new CarRentalContext();
            EditCarViewModel ecvm = new EditCarViewModel();
            ecvm.CarData = car;
            ecvm.Branches = new SelectList(db.Branches, "BranchId", "BranchName", car.BranchId);
            ecvm.CarTypes = new SelectList(db.CarTypes, "CarTypeId", "Description", car.CarTypeId);
            return ecvm;
        }

        public static EditCarViewModel CreateCarViewModel(int? id)
        {
            CarRentalContext db = new CarRentalContext();
            Car car = db.Cars.Find(id);
            if (car != null)
            {
                //There is some code that is executed twice, but it's worth considering we abide by the DRY principle
                return createVM(car);
            }
            return null; //todo return an error or make View return an error
        }

        public static EditCarViewModel CreateCarViewModel(Car car)
        {
            return createVM(car);
        }

        public static EditCarViewModel CreateCarViewModel()
        {
            return createVM(new Car());
        }

    }


}