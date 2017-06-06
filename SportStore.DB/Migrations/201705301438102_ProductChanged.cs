namespace SportStore.DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "BrandName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "BrandName");
        }
    }
}
