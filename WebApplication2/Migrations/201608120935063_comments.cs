namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class comments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chapters", "Comments", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Chapters", "Comments");
        }
    }
}