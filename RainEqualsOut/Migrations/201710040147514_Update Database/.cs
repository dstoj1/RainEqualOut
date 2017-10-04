namespace RainEqualsOut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Carts", new[] { "User_Id1" });
            DropColumn("dbo.Carts", "User_Id");
            RenameColumn(table: "dbo.Carts", name: "User_Id1", newName: "User_Id");
            AddColumn("dbo.Carts", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Carts", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Carts", "CustomerId");
            CreateIndex("dbo.Carts", "User_Id");
            AddForeignKey("dbo.Carts", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Carts", new[] { "User_Id" });
            DropIndex("dbo.Carts", new[] { "CustomerId" });
            AlterColumn("dbo.Carts", "User_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Carts", "CustomerId");
            RenameColumn(table: "dbo.Carts", name: "User_Id", newName: "User_Id1");
            AddColumn("dbo.Carts", "User_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Carts", "User_Id1");
        }
    }
}
