namespace Barovi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class konecno2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Image = c.String(),
                        Location = c.String(),
                        Price = c.Int(nullable: false),
                        Age = c.String(),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
