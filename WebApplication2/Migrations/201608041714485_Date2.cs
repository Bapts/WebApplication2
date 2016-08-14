namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Date2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTimeOffset(nullable: false));
            AddColumn("dbo.AspNetUsers", "RegisterTime", c => c.DateTimeOffset(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "RegisterTime");
            DropColumn("dbo.AspNetUsers", "BirthDate");
        }
    }
}
