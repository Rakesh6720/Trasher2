namespace Trasher2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerModelAttributes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "FirstMidName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "ZipCode", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Customers", "PickupDay", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "PickupDay", c => c.String());
            AlterColumn("dbo.Customers", "ZipCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "LastName", c => c.String());
            AlterColumn("dbo.Customers", "FirstMidName", c => c.String());
        }
    }
}
