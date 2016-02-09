namespace Ajax5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixHeadlineRestriction : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Articles", "Headline", c => c.String(nullable: false, maxLength: 90));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Articles", "Headline", c => c.String(nullable: false));
        }
    }
}
