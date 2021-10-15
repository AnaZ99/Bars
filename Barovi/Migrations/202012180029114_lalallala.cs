namespace Barovi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lalallala : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bars", "Lat", c => c.String());
            AddColumn("dbo.Bars", "Lon", c => c.String());
            DropColumn("dbo.Bars", "Location");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bars", "Location", c => c.String());
            DropColumn("dbo.Bars", "Lon");
            DropColumn("dbo.Bars", "Lat");
        }
    }
}
