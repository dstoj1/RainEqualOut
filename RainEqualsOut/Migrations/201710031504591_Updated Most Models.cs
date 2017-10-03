namespace RainEqualsOut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedMostModels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Carts", "User_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Carts", "Quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.Inventories", "Price", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "Phone", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderDetails", "User_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderDetails", "DateOfPurchase", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderDetails", "TotalAmount", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderItems", "OrderId", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderItems", "TotalOfEachItem", c => c.Int(nullable: false));
            AlterColumn("dbo.Stocks", "Iventory_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Stocks", "TotalOfEach", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Stocks", "TotalOfEach", c => c.String());
            AlterColumn("dbo.Stocks", "Iventory_Id", c => c.String());
            AlterColumn("dbo.OrderItems", "TotalOfEachItem", c => c.String());
            AlterColumn("dbo.OrderItems", "OrderId", c => c.String());
            AlterColumn("dbo.OrderDetails", "TotalAmount", c => c.String());
            AlterColumn("dbo.OrderDetails", "DateOfPurchase", c => c.String());
            AlterColumn("dbo.OrderDetails", "User_Id", c => c.String());
            AlterColumn("dbo.Customers", "Phone", c => c.String());
            AlterColumn("dbo.Inventories", "Price", c => c.String());
            AlterColumn("dbo.Carts", "Quantity", c => c.String());
            AlterColumn("dbo.Carts", "User_Id", c => c.String());
        }
    }
}
