namespace SportStore.DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductImageAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ImageData", c => c.Binary());
            AddColumn("dbo.Products", "ImageMIMEType", c => c.String());
            DropColumn("dbo.Products", "BrandName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "BrandName", c => c.String());
            DropColumn("dbo.Products", "ImageMIMEType");
            DropColumn("dbo.Products", "ImageData");
        }
    }
}
