namespace RainEqualsOut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStockViewDataModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Stocks", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Stocks", new[] { "User_Id" });
            DropColumn("dbo.Stocks", "Iventory_Id");
            DropColumn("dbo.Stocks", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stocks", "User_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Stocks", "Iventory_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Stocks", "User_Id");
            AddForeignKey("dbo.Stocks", "User_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
