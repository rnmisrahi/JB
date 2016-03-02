namespace CarRental02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class car2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CarModel", "CarBrand_BrandName", "dbo.CarBrand");
            DropIndex("dbo.CarModel", new[] { "CarBrand_BrandName" });
            DropColumn("dbo.CarModel", "CarBrandId");
            RenameColumn(table: "dbo.CarModel", name: "CarBrand_BrandName", newName: "CarBrandId");
            DropPrimaryKey("dbo.CarBrand");
            AlterColumn("dbo.CarModel", "CarBrandId", c => c.Int(nullable: false));
            AlterColumn("dbo.CarBrand", "BrandName", c => c.String());
            AlterColumn("dbo.CarBrand", "CarBrandId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.CarBrand", "CarBrandId");
            CreateIndex("dbo.CarModel", "CarBrandId");
            AddForeignKey("dbo.CarModel", "CarBrandId", "dbo.CarBrand", "CarBrandId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CarModel", "CarBrandId", "dbo.CarBrand");
            DropIndex("dbo.CarModel", new[] { "CarBrandId" });
            DropPrimaryKey("dbo.CarBrand");
            AlterColumn("dbo.CarBrand", "CarBrandId", c => c.Int(nullable: false));
            AlterColumn("dbo.CarBrand", "BrandName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.CarModel", "CarBrandId", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.CarBrand", "BrandName");
            RenameColumn(table: "dbo.CarModel", name: "CarBrandId", newName: "CarBrand_BrandName");
            AddColumn("dbo.CarModel", "CarBrandId", c => c.Int(nullable: false));
            CreateIndex("dbo.CarModel", "CarBrand_BrandName");
            AddForeignKey("dbo.CarModel", "CarBrand_BrandName", "dbo.CarBrand", "BrandName");
        }
    }
}
