namespace Ajax5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        Headline = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.ArticleId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Articles");
        }
    }
}
