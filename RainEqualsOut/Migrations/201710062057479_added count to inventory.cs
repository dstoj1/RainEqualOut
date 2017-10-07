namespace RainEqualsOut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcounttoinventory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Inventories", "amount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Inventories", "amount");
        }
    }
}
