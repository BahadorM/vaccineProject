namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Turns",
                c => new
                    {
                        TurnID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        DateTurn = c.DateTime(nullable: false),
                        DoseTime = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TurnID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        NationalNumber = c.Int(nullable: false),
                        DateBrith = c.DateTime(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        SecurityCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turns", "UserID", "dbo.Users");
            DropIndex("dbo.Turns", new[] { "UserID" });
            DropTable("dbo.Users");
            DropTable("dbo.Turns");
        }
    }
}
