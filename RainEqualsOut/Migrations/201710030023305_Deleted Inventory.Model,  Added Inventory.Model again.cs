namespace RainEqualsOut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedInventoryModelAddedInventoryModelagain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Inventories", "ProductName", c => c.String());
            AddColumn("dbo.Inventories", "Type", c => c.String());
            DropColumn("dbo.Inventories", "Product");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Inventories", "Product", c => c.String());
            DropColumn("dbo.Inventories", "Type");
            DropColumn("dbo.Inventories", "ProductName");
        }
    }
}
