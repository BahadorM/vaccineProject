namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.States",
                c => new
                    {
                        CityID = c.Int(nullable: false, identity: true),
                        cityName = c.String(nullable: false),
                        Users_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.CityID)
                .ForeignKey("dbo.Users", t => t.Users_UserID)
                .Index(t => t.Users_UserID);
            
            AddColumn("dbo.Users", "CityID", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "City");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "City", c => c.String(nullable: false));
            DropForeignKey("dbo.States", "Users_UserID", "dbo.Users");
            DropIndex("dbo.States", new[] { "Users_UserID" });
            DropColumn("dbo.Users", "CityID");
            DropTable("dbo.States");
        }
    }
}
