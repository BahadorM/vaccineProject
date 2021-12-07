namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatetables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Turns", "InjectionDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "City", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "City");
            DropColumn("dbo.Turns", "InjectionDate");
        }
    }
}
