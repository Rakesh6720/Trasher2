namespace Trasher2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "TrasherEmployeeId", "dbo.Employees");
            DropIndex("dbo.Customers", new[] { "TrasherEmployeeId" });
            AddColumn("dbo.Customers", "PickupDayTwo", c => c.String());
            AddColumn("dbo.Customers", "IsDayTwoPickedUp", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "TrasherEmployeeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "TrasherEmployeeId", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "IsDayTwoPickedUp");
            DropColumn("dbo.Customers", "PickupDayTwo");
            CreateIndex("dbo.Customers", "TrasherEmployeeId");
            AddForeignKey("dbo.Customers", "TrasherEmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
    }
}
