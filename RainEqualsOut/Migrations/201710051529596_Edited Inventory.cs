namespace RainEqualsOut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditedInventory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Inventories", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Inventories", "Photo");
        }
    }
}
