namespace RainEqualsOut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedCartModelandEditedInventoryanStockModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Stocks", "Inventory_ID", "dbo.Inventories");
            DropIndex("dbo.Stocks", new[] { "Inventory_ID" });
            RenameColumn(table: "dbo.Stocks", name: "Inventory_ID", newName: "InventoryId");
            AddColumn("dbo.Inventories", "Product", c => c.String());
            AddColumn("dbo.Inventories", "Price", c => c.String());
            AlterColumn("dbo.Stocks", "InventoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Stocks", "InventoryId");
            AddForeignKey("dbo.Stocks", "InventoryId", "dbo.Inventories", "ID", cascadeDelete: true);
            DropColumn("dbo.Inventories", "ProductName");
            DropColumn("dbo.Inventories", "Cost");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Inventories", "Cost", c => c.String());
            AddColumn("dbo.Inventories", "ProductName", c => c.String());
            DropForeignKey("dbo.Stocks", "InventoryId", "dbo.Inventories");
            DropIndex("dbo.Stocks", new[] { "InventoryId" });
            AlterColumn("dbo.Stocks", "InventoryId", c => c.Int());
            DropColumn("dbo.Inventories", "Price");
            DropColumn("dbo.Inventories", "Product");
            RenameColumn(table: "dbo.Stocks", name: "InventoryId", newName: "Inventory_ID");
            CreateIndex("dbo.Stocks", "Inventory_ID");
            AddForeignKey("dbo.Stocks", "Inventory_ID", "dbo.Inventories", "ID");
        }
    }
}
