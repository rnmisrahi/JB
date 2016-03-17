namespace CarRental02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branch",
                c => new
                    {
                        BranchId = c.Int(nullable: false, identity: true),
                        CityId = c.Int(nullable: false),
                        BranchName = c.String(),
                        Location = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.BranchId)
                .ForeignKey("dbo.City", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
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
                        Plates = c.String(nullable: false),
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
                        CarCode = c.String(nullable: false),
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
                        ModelName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CarModelId)
                .ForeignKey("dbo.CarBrand", t => t.CarBrandId, cascadeDelete: true)
                .Index(t => t.CarBrandId);
            
            CreateTable(
                "dbo.CarBrand",
                c => new
                    {
                        CarBrandId = c.Int(nullable: false, identity: true),
                        BrandName = c.String(nullable: false),
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
            
            CreateTable(
                "dbo.City",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Member", "Branch_BranchId", "dbo.Branch");
            DropForeignKey("dbo.Branch", "CityId", "dbo.City");
            DropForeignKey("dbo.Reservation", "Member_SSN", "dbo.Member");
            DropForeignKey("dbo.Reservation", "CarId", "dbo.Car");
            DropForeignKey("dbo.Reservation", "BranchId", "dbo.Branch");
            DropForeignKey("dbo.Car", "CarTypeId", "dbo.CarType");
            DropForeignKey("dbo.CarType", "CarModelId", "dbo.CarModel");
            DropForeignKey("dbo.Car", "CarModel_CarModelId", "dbo.CarModel");
            DropForeignKey("dbo.CarModel", "CarBrandId", "dbo.CarBrand");
            DropForeignKey("dbo.Car", "BranchId", "dbo.Branch");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Member", new[] { "Branch_BranchId" });
            DropIndex("dbo.Reservation", new[] { "Member_SSN" });
            DropIndex("dbo.Reservation", new[] { "CarId" });
            DropIndex("dbo.Reservation", new[] { "BranchId" });
            DropIndex("dbo.CarModel", new[] { "CarBrandId" });
            DropIndex("dbo.CarType", new[] { "CarModelId" });
            DropIndex("dbo.Car", new[] { "CarModel_CarModelId" });
            DropIndex("dbo.Car", new[] { "BranchId" });
            DropIndex("dbo.Car", new[] { "CarTypeId" });
            DropIndex("dbo.Branch", new[] { "CityId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.City");
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
