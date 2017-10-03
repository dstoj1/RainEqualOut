namespace RainEqualsOut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedOrderItemsUpdatedOrderDetailsandIdentityModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Id = c.String(),
                        Item = c.String(),
                        Quantity = c.String(),
                        InventoryId = c.Int(nullable: false),
                        User_Id1 = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Inventories", t => t.InventoryId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id1)
                .Index(t => t.InventoryId)
                .Index(t => t.User_Id1);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        ItemsPurchased = c.String(),
                        User_Id = c.String(),
                        StatusOfDelivery = c.String(),
                        DateOfPurchase = c.String(),
                        TotalAmount = c.String(),
                        Pament = c.String(),
                        ShipToAddress = c.String(),
                        User_Id1 = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id1)
                .Index(t => t.User_Id1);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.String(),
                        Item = c.String(),
                        TotalOfEachItem = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.OrderDetails", "User_Id1", "dbo.AspNetUsers");
            DropForeignKey("dbo.Carts", "User_Id1", "dbo.AspNetUsers");
            DropForeignKey("dbo.Carts", "InventoryId", "dbo.Inventories");
            DropIndex("dbo.OrderItems", new[] { "User_Id" });
            DropIndex("dbo.OrderDetails", new[] { "User_Id1" });
            DropIndex("dbo.Carts", new[] { "User_Id1" });
            DropIndex("dbo.Carts", new[] { "InventoryId" });
            DropTable("dbo.OrderItems");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Carts");
        }
    }
}
