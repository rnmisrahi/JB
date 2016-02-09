namespace Ef6Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityID = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.CityID);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberID = c.Int(nullable: false, identity: true),
                        MemberName = c.String(),
                        Amount = c.Int(nullable: false),
                        City_CityID = c.Int(),
                    })
                .PrimaryKey(t => t.MemberID)
                .ForeignKey("dbo.Cities", t => t.City_CityID)
                .Index(t => t.City_CityID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "City_CityID", "dbo.Cities");
            DropIndex("dbo.Members", new[] { "City_CityID" });
            DropTable("dbo.Members");
            DropTable("dbo.Cities");
        }
    }
}
