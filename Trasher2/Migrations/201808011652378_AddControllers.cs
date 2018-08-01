namespace Trasher2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddControllers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstMidName = c.String(),
                        LastName = c.String(),
                        ZipCode = c.Int(nullable: false),
                        PickupDay = c.String(),
                        TrasherEmployeeId = c.Int(nullable: false),
                        IsDayOnePickedUp = c.Boolean(nullable: false),
                        AmountDue = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Employees", t => t.TrasherEmployeeId, cascadeDelete: true)
                .Index(t => t.TrasherEmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstMidName = c.String(),
                        LastName = c.String(),
                        ZipCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "TrasherEmployeeId", "dbo.Employees");
            DropIndex("dbo.Customers", new[] { "TrasherEmployeeId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
        }
    }
}
