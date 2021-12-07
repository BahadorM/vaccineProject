namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changevariable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "PhoneNumber", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "PhoneNumber", c => c.Int(nullable: false));
        }
    }
}
