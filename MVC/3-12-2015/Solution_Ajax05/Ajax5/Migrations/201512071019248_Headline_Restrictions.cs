namespace Ajax5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Headline_Restrictions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Articles", "Headline", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Articles", "Headline", c => c.String());
        }
    }
}
