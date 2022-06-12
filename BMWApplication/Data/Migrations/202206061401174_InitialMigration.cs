namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        YearOfCreattion = c.Int(nullable: false),
                        EngineSize = c.Int(nullable: false),
                        Fuel = c.String(maxLength: 15),
                        Coupe = c.String(maxLength: 15),
                        Color = c.String(maxLength: 15),
                        CreatedBy = c.Int(nullable: false),
                        CreatedOn = c.DateTime(),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Offerts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 250),
                        CarId = c.Int(nullable: false),
                        SallemenId = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        CreatedOn = c.DateTime(),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: false)
                .ForeignKey("dbo.Sallemen", t => t.SallemenId, cascadeDelete: false)
                .Index(t => t.CarId)
                .Index(t => t.SallemenId);
            
            CreateTable(
                "dbo.Sallemen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(maxLength: 15),
                        City = c.String(maxLength: 15),
                        Age = c.Int(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        CreatedOn = c.DateTime(),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Offerts", "SallemenId", "dbo.Sallemen");
            DropForeignKey("dbo.Offerts", "CarId", "dbo.Cars");
            DropIndex("dbo.Offerts", new[] { "SallemenId" });
            DropIndex("dbo.Offerts", new[] { "CarId" });
            DropTable("dbo.Sallemen");
            DropTable("dbo.Offerts");
            DropTable("dbo.Cars");
        }
    }
}
