namespace SportStore.DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImagedataAddedinProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ImageData", c => c.Binary());
            AddColumn("dbo.Products", "ImageMIMEType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ImageMIMEType");
            DropColumn("dbo.Products", "ImageData");
        }
    }
}
