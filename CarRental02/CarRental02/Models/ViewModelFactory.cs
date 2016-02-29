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
        public static EditCarTypeViewModel CreateEditCarTypeViewModel(int id)
        {
            CarRentalContext db = new CarRentalContext();
            CarType carType = db.CarTypes.Find(id);
            if (carType != null)
            {
                EditCarTypeViewModel ectvm = new EditCarTypeViewModel();
                ectvm.CarTypeData = carType;
                ectvm.CarModels = db.CarModels.ToList();
            }
            return null;
        }

        public static EditCarViewModel CreateCarViewModel(int? id)
        {
            CarRentalContext db = new CarRentalContext();
            Car car = db.Cars.Find(id);
            if (car != null)
            {
                EditCarViewModel ecvm = new EditCarViewModel();
                ecvm.CarData = car;
                ecvm.Branches = new SelectList(db.Branches, "BranchId", "BranchName", car.BranchId);
                ecvm.CarTypes = new SelectList(db.CarTypes, "CarTypeId", "CarCode", car.CarTypeId);
                return ecvm;
            }
            return null; //todo return an error or make View return an error
        }

        public static EditCarViewModel CreateCarViewModel(Car car)
        {
            CarRentalContext db = new CarRentalContext();
            EditCarViewModel ecvm = new EditCarViewModel();
            ecvm.CarData = car;
            ecvm.Branches = new SelectList(db.Branches, "BranchId", "BranchName", car.BranchId);
            ecvm.CarTypes = new SelectList(db.CarTypes, "CarTypeId", "CarCode", car.CarTypeId);
            return ecvm;
        }

    }


}