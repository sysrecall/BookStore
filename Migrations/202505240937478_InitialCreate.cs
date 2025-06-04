namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        lastName = c.String(),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Department = c.String(),
                        Position = c.String(),
                        JoinDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author = c.String(),
                        Publisher = c.String(),
                        PublicationYear = c.DateTime(nullable: false),
                        Pages = c.Int(nullable: false),
                        Edition = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        BookType = c.Int(nullable: false),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.User_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.BookCoverImage",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ImageURL = c.String(),
                        Book_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Book", t => t.Book_ID)
                .Index(t => t.Book_ID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        PasswordHash = c.String(),
                        FullName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Book", "User_ID", "dbo.User");
            DropForeignKey("dbo.BookCoverImage", "Book_ID", "dbo.Book");
            DropIndex("dbo.BookCoverImage", new[] { "Book_ID" });
            DropIndex("dbo.Book", new[] { "User_ID" });
            DropTable("dbo.User");
            DropTable("dbo.BookCoverImage");
            DropTable("dbo.Book");
            DropTable("dbo.Admin");
        }
    }
}
