namespace RainEqualsOut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class didstuffagain : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Stocks", "InventoryId", "dbo.Inventories");
            DropIndex("dbo.Stocks", new[] { "InventoryId" });
            RenameColumn(table: "dbo.Stocks", name: "InventoryId", newName: "Inventory_ID");
            AlterColumn("dbo.Stocks", "Inventory_ID", c => c.Int());
            CreateIndex("dbo.Stocks", "Inventory_ID");
            AddForeignKey("dbo.Stocks", "Inventory_ID", "dbo.Inventories", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "Inventory_ID", "dbo.Inventories");
            DropIndex("dbo.Stocks", new[] { "Inventory_ID" });
            AlterColumn("dbo.Stocks", "Inventory_ID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Stocks", name: "Inventory_ID", newName: "InventoryId");
            CreateIndex("dbo.Stocks", "InventoryId");
            AddForeignKey("dbo.Stocks", "InventoryId", "dbo.Inventories", "ID", cascadeDelete: true);
        }
    }
}
