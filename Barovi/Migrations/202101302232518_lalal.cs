namespace Barovi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lalal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bars", "Kapacitet", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bars", "Kapacitet");
        }
    }
}
