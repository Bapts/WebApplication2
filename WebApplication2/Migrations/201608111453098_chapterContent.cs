namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chapterContent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chapters", "Content", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Chapters", "Content");
        }
    }
}
