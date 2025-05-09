namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAdminModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admin", "FirstName", c => c.String());
            AddColumn("dbo.Admin", "lastName", c => c.String());
            AddColumn("dbo.Admin", "Department", c => c.String());
            AddColumn("dbo.Admin", "Position", c => c.String());
            AddColumn("dbo.Admin", "JoinDate", c => c.String());
            DropColumn("dbo.Admin", "Username");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admin", "Username", c => c.String());
            DropColumn("dbo.Admin", "JoinDate");
            DropColumn("dbo.Admin", "Position");
            DropColumn("dbo.Admin", "Department");
            DropColumn("dbo.Admin", "lastName");
            DropColumn("dbo.Admin", "FirstName");
        }
    }
}
