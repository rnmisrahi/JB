namespace CarRental02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarTypeUniqueCarCode : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CarType", "CarCode", c => c.String(nullable: false, maxLength: 1));
            CreateIndex("dbo.CarType", "CarCode", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.CarType", new[] { "CarCode" });
            AlterColumn("dbo.CarType", "CarCode", c => c.String(nullable: false));
        }
    }
}
