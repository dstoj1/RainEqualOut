namespace RainEqualsOut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedIdentityModelswithDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Product = c.String(),
                        Description = c.String(),
                        Size = c.String(),
                        Color = c.String(),
                        Cost = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Inventories");
        }
    }
}
