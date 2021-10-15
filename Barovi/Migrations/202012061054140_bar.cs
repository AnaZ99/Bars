namespace Barovi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bars",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Image = c.String(),
                        Location = c.String(),
                        Phone = c.String(),
                        Rating = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bars");
        }
    }
}
