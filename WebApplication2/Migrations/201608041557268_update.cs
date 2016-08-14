namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "RegisterTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "RegisterTime", c => c.DateTime(nullable: false));
        }
    }
}
