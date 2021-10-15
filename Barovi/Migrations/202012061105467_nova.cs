namespace Barovi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nova : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Bars");
            AddColumn("dbo.Bars", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Bars", "Name", c => c.String());
            AddPrimaryKey("dbo.Bars", "Id");
        }
        public override void Down()
        {
            DropPrimaryKey("dbo.Bars");
            AlterColumn("dbo.Bars", "Name", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Bars", "Id");
            AddPrimaryKey("dbo.Bars", "Name");
        }
    }
}
