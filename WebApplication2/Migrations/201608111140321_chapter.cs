namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chapter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chapters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        ChapterNumber = c.Int(nullable: false),
                        CreatorName = c.String(),
                        CreatorId = c.String(),
                        CreationTime = c.DateTimeOffset(nullable: false, precision: 7),
                        UpVote = c.Int(nullable: false),
                        DownVote = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Chapters");
        }
    }
}
