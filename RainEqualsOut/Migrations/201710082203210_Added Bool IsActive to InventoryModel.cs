namespace RainEqualsOut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBoolIsActivetoInventoryModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Inventories", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Inventories", "IsActive");
        }
    }
}
