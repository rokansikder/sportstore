namespace SportStore.DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Database_Changed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CartLines",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Product_ProductID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.Product_ProductID)
                .Index(t => t.Product_ProductID);
            
            CreateTable(
                "dbo.ShippingDetails",
                c => new
                    {
                        ShippingDetailsID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Line1 = c.String(nullable: false),
                        Line2 = c.String(),
                        Line3 = c.String(),
                        City = c.String(nullable: false),
                        State = c.String(nullable: false),
                        Zip = c.String(),
                        Country = c.String(nullable: false),
                        GiftWrap = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ShippingDetailsID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CartLines", "Product_ProductID", "dbo.Products");
            DropIndex("dbo.CartLines", new[] { "Product_ProductID" });
            DropTable("dbo.ShippingDetails");
            DropTable("dbo.CartLines");
        }
    }
}
