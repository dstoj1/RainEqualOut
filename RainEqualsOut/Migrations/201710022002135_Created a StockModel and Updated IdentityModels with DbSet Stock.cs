namespace RainEqualsOut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedaStockModelandUpdatedIdentityModelswithDbSetStock : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Iventory_Id = c.String(),
                        TotalOfEach = c.String(),
                        Inventory_ID = c.Int(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Inventories", t => t.Inventory_ID)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.Inventory_ID)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Stocks", "Inventory_ID", "dbo.Inventories");
            DropIndex("dbo.Stocks", new[] { "User_Id" });
            DropIndex("dbo.Stocks", new[] { "Inventory_ID" });
            DropTable("dbo.Stocks");
        }
    }
}
