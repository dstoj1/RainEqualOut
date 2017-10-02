namespace RainEqualsOut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUsertotheInventory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Inventories", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Inventories", "User_Id");
            AddForeignKey("dbo.Inventories", "User_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inventories", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Inventories", new[] { "User_Id" });
            DropColumn("dbo.Inventories", "User_Id");
        }
    }
}
