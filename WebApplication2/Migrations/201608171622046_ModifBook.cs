namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifBook : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "NbrContribution", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "State", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "Genre", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Genre");
            DropColumn("dbo.Books", "State");
            DropColumn("dbo.Books", "NbrContribution");
        }
    }
}
