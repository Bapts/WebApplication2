namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class booktitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chapters", "BookTitle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Chapters", "BookTitle");
        }
    }
}
