namespace CarRental02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branch",
                c => new
                    {
                        BranchId = c.Int(nullable: false, identity: true),
                        BranchName = c.String(),
                        Location = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.BranchId);
            
            CreateTable(
                "dbo.Car",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        CarTypeId = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                        CarColor = c.String(),
                        Kilometrage = c.Int(nullable: false),
                        Picture = c.String(),
                        Plates = c.String(),
                        CarStatus = c.Int(),
                        Comments = c.String(),
                        CarModel_CarModelId = c.Int(),
                    })
                .PrimaryKey(t => t.CarId)
                .ForeignKey("dbo.Branch", t => t.BranchId, cascadeDelete: true)
                .ForeignKey("dbo.CarModel", t => t.CarModel_CarModelId)
                .ForeignKey("dbo.CarType", t => t.CarTypeId, cascadeDelete: true)
                .Index(t => t.CarTypeId)
                .Index(t => t.BranchId)
                .Index(t => t.CarModel_CarModelId);
            
            CreateTable(
                "dbo.CarType",
                c => new
                    {
                        CarTypeId = c.Int(nullable: false, identity: true),
                        CarModelId = c.Int(nullable: false),
                        DailyPrice = c.Double(nullable: false),
                        DailyLatePrice = c.Double(nullable: false),
                        Gear = c.Int(),
                    })
                .PrimaryKey(t => t.CarTypeId)
                .ForeignKey("dbo.CarModel", t => t.CarModelId, cascadeDelete: true)
                .Index(t => t.CarModelId);
            
            CreateTable(
                "dbo.CarModel",
                c => new
                    {
                        CarModelId = c.Int(nullable: false, identity: true),
                        CarBrandId = c.Int(nullable: false),
                        ModelName = c.String(),
                    })
                .PrimaryKey(t => t.CarModelId)
                .ForeignKey("dbo.CarBrand", t => t.CarBrandId, cascadeDelete: true)
                .Index(t => t.CarBrandId);
            
            CreateTable(
                "dbo.CarBrand",
                c => new
                    {
                        CarBrandId = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                    })
                .PrimaryKey(t => t.CarBrandId);
            
            CreateTable(
                "dbo.Reservation",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        BranchId = c.Int(nullable: false),
                        MemberId = c.String(),
                        CarId = c.Int(nullable: false),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        DateReturned = c.DateTime(nullable: false),
                        ReservationStatus = c.Int(),
                        Member_SSN = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ReservationId)
                .ForeignKey("dbo.Branch", t => t.BranchId, cascadeDelete: true)
                .ForeignKey("dbo.Car", t => t.CarId)
                .ForeignKey("dbo.Member", t => t.Member_SSN)
                .Index(t => t.BranchId)
                .Index(t => t.CarId)
                .Index(t => t.Member_SSN);
            
            CreateTable(
                "dbo.Member",
                c => new
                    {
                        SSN = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(nullable: false),
                        HashedPassword = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Gender = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        Address = c.String(),
                        Phone = c.String(),
                        Picture = c.String(),
                        FromDate = c.DateTime(nullable: false),
                        Discount = c.Double(nullable: false),
                        Shift = c.String(),
                        Salary = c.Double(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Branch_BranchId = c.Int(),
                    })
                .PrimaryKey(t => t.SSN)
                .ForeignKey("dbo.Branch", t => t.Branch_BranchId)
                .Index(t => t.Branch_BranchId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Member", "Branch_BranchId", "dbo.Branch");
            DropForeignKey("dbo.Reservation", "Member_SSN", "dbo.Member");
            DropForeignKey("dbo.Reservation", "CarId", "dbo.Car");
            DropForeignKey("dbo.Reservation", "BranchId", "dbo.Branch");
            DropForeignKey("dbo.Car", "CarTypeId", "dbo.CarType");
            DropForeignKey("dbo.CarType", "CarModelId", "dbo.CarModel");
            DropForeignKey("dbo.Car", "CarModel_CarModelId", "dbo.CarModel");
            DropForeignKey("dbo.CarModel", "CarBrandId", "dbo.CarBrand");
            DropForeignKey("dbo.Car", "BranchId", "dbo.Branch");
            DropIndex("dbo.Member", new[] { "Branch_BranchId" });
            DropIndex("dbo.Reservation", new[] { "Member_SSN" });
            DropIndex("dbo.Reservation", new[] { "CarId" });
            DropIndex("dbo.Reservation", new[] { "BranchId" });
            DropIndex("dbo.CarModel", new[] { "CarBrandId" });
            DropIndex("dbo.CarType", new[] { "CarModelId" });
            DropIndex("dbo.Car", new[] { "CarModel_CarModelId" });
            DropIndex("dbo.Car", new[] { "BranchId" });
            DropIndex("dbo.Car", new[] { "CarTypeId" });
            DropTable("dbo.Member");
            DropTable("dbo.Reservation");
            DropTable("dbo.CarBrand");
            DropTable("dbo.CarModel");
            DropTable("dbo.CarType");
            DropTable("dbo.Car");
            DropTable("dbo.Branch");
        }
    }
}
