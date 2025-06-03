namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        PasswordHash = c.String(nullable: false),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.User", "AccountID", c => c.String());
            AddColumn("dbo.User", "Account_ID", c => c.Int());
            CreateIndex("dbo.User", "Account_ID");
            AddForeignKey("dbo.User", "Account_ID", "dbo.Account", "ID");
            DropColumn("dbo.User", "Username");
            DropColumn("dbo.User", "PasswordHash");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "PasswordHash", c => c.String());
            AddColumn("dbo.User", "Username", c => c.String());
            DropForeignKey("dbo.User", "Account_ID", "dbo.Account");
            DropIndex("dbo.User", new[] { "Account_ID" });
            DropColumn("dbo.User", "Account_ID");
            DropColumn("dbo.User", "AccountID");
            DropTable("dbo.Account");
        }
    }
}
