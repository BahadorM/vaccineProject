namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changestate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.States", "Users_UserID", "dbo.Users");
            DropIndex("dbo.States", new[] { "Users_UserID" });
            CreateIndex("dbo.Users", "CityID");
            AddForeignKey("dbo.Users", "CityID", "dbo.States", "CityID", cascadeDelete: true);
            DropColumn("dbo.States", "Users_UserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.States", "Users_UserID", c => c.Int());
            DropForeignKey("dbo.Users", "CityID", "dbo.States");
            DropIndex("dbo.Users", new[] { "CityID" });
            CreateIndex("dbo.States", "Users_UserID");
            AddForeignKey("dbo.States", "Users_UserID", "dbo.Users", "UserID");
        }
    }
}
