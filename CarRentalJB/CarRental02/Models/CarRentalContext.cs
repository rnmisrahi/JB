﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CarRental02.Models
{
    public class CarRentalContext : ApplicationDbContext
    {
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<FilePath> FilePaths { get; set; }
        public DbSet<File> Files { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Reservation>().HasRequired(t => t.Car).WithMany(
            //  p => p.Reservations).HasForeignKey(t => t.Car).WillCascadeOnDelete(false);
            //modelBuilder.Entity<Reservation>().HasRequired(t => t.Car).WithMany(
            //  p => p.Reservations).HasForeignKey(t => t.Car).WillCascadeOnDelete(false);
            //modelBuilder.Entity<Reservation>().HasRequired(p => p.Car);
        }

        public DbSet<CarRental02.Models.City> Cities { get; set; }

        //public System.Data.Entity.DbSet<CarRental02.ViewModels.SearchCarViewModel> SearchCarViewModels { get; set; }
    }
}