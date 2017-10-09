namespace RainEqualsOut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedStockModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Stocks", "Inventory_ID", "dbo.Inventories");
            DropIndex("dbo.Stocks", new[] { "Inventory_ID" });
            DropTable("dbo.Stocks");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TotalOfEach = c.Int(nullable: false),
                        Inventory_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.Stocks", "Inventory_ID");
            AddForeignKey("dbo.Stocks", "Inventory_ID", "dbo.Inventories", "ID");
        }
    }
}
