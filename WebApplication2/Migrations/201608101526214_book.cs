namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class book : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Summary = c.String(),
                        Authors = c.String(),
                        LastChapter = c.String(),
                        CreationTime = c.DateTimeOffset(nullable: false, precision: 7),
                        LastModificationDate = c.DateTimeOffset(nullable: false, precision: 7),
                        FrontImage = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
