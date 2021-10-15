namespace Barovi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aloo : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Bars");
            AddColumn("dbo.Bars", "Hours", c => c.String());
            AlterColumn("dbo.Bars", "Name", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Bars", "Name");
            DropColumn("dbo.Bars", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bars", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Bars");
            AlterColumn("dbo.Bars", "Name", c => c.String());
            DropColumn("dbo.Bars", "Hours");
            AddPrimaryKey("dbo.Bars", "Id");
        }
    }
}
