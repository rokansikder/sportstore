namespace SportStore.DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImagedatabadfromProduct : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "ImageData");
            DropColumn("dbo.Products", "ImageMIMEType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ImageMIMEType", c => c.String());
            AddColumn("dbo.Products", "ImageData", c => c.Binary());
        }
    }
}
