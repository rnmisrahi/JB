using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CarRental02.Models
{
    public class CarRentalContext : DbContext
    {
        public CarRentalContext() : base("CarRentalContext")
        {
        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Reservation>().HasRequired(t => t.Car).WithMany(
            //  p => p.Reservations).HasForeignKey(t => t.Car).WillCascadeOnDelete(false);
            modelBuilder.Entity<Reservation>().HasRequired(t => t.Car).WithMany(
              p => p.Reservations).HasForeignKey(t => t.Car).WillCascadeOnDelete(false);
            modelBuilder.Entity<Reservation>().HasRequired(p => p.Car);
        }

        public System.Data.Entity.DbSet<CarRental02.ViewModels.CarModelVM2> CarModelVM2 { get; set; }

        //public System.Data.Entity.DbSet<CarRental02.ViewModels.CarModelVM> CarModelVMs { get; set; }
    }
}