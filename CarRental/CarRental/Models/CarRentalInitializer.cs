using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CarRental.Models
{
    public class CarRentalInitializer : DropCreateDatabaseAlways<CarRentalContext>
    {

        protected override void Seed(CarRentalContext context)
        {
            base.Seed(context);
            var Branches = new List<Branch>
            {
                new Branch { BranchName = "Talpiot", Phone = "02-555-2345", Location="Derech Hebron 201" },
                new Branch { BranchName = "Katamon", Phone = "02-666-2345", Location = "HaPalmach 26" },
                new Branch { BranchName = "Ben Gurion", Phone = "02-777-2345", Location="Ben Gurion Airport" }
            };
            context.SaveChanges();

            var CarBrands = new List<CarBrand>
            {
                new CarBrand {BrandName="Honda"},
                new CarBrand {BrandName="Hyundai" },
                new CarBrand {BrandName="Ford" },
                new CarBrand {BrandName="Chevrolet" },
                new CarBrand {BrandName="Toyota" }
            };

            var CarModels = new List<CarModel>
            {
                new CarModel {CarBrandId=0, ModelName="Acura"},
                new CarModel {CarBrandId=0,ModelName="Accord" },
                new CarModel {CarBrandId=1,ModelName="Sonata" },
                new CarModel {CarBrandId=2,ModelName="Focus" },
                new CarModel {CarBrandId=2,ModelName="Mustang" }
            };

            var CarTypes = new List<CarType>
            {
                new CarType {CarModelId=0, DailyLatePrice=200, DailyPrice=150,Gear=Gear.Automatic },
                new CarType {CarModelId=0, DailyPrice=170, DailyLatePrice=220, Gear=Gear.Automatic },
                new CarType {CarModelId=3,DailyPrice=50,DailyLatePrice=70,Gear=Gear.Shift },
                new CarType {CarModelId=2,DailyPrice=120,DailyLatePrice=145,Gear=Gear.Automatic },
                new CarType {CarModelId=2,DailyPrice=110,DailyLatePrice=135,Gear=Gear.Shift },
            };

            var Cars = new List<Car>
            {
                new Car {CarTypeId=0,BranchId=0,CarColor="White",Kilometrage=45000,Plates="234-2673", CarStatus=CarStatus.Available  },
                new Car {CarTypeId=0,BranchId=0,CarColor="Blue",Kilometrage=30000,Plates="376-2273", CarStatus=CarStatus.Available  },
                new Car {CarTypeId=1,BranchId=1,CarColor="Red",Kilometrage=21000,Plates="678-2673", CarStatus=CarStatus.Available  },
                new Car {CarTypeId=2,BranchId=1,CarColor="White",Kilometrage=95000,Plates="785-2673", CarStatus=CarStatus.InRepair  },
                new Car {CarTypeId=3,BranchId=2,CarColor="Grey",Kilometrage=12000,Plates="378-2673", CarStatus=CarStatus.Rented  },
                new Car {CarTypeId=3,BranchId=2,CarColor="Blue",Kilometrage=74300,Plates="763-2673", CarStatus=CarStatus.Available  },
                new Car {CarTypeId=4,BranchId=0,CarColor="Black",Kilometrage=120000,Plates="999-2673", CarStatus=CarStatus.Available  },
            };

            var Reservations = new List<Reservation>
            {
                new Reservation {BranchId=0,CarId=0,MemberId="123456789" },
                new Reservation {BranchId=0,CarId=1,MemberId="111222333" },
            };

        }
    }
}