namespace SportStore.DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewArchitechture : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CategoryID = c.Int(nullable: false),
                        Logo = c.String(),
                        ImageMIMETYPE = c.String(),
                    })
                .PrimaryKey(t => t.BrandID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        ImagePath = c.String(),
                        ImageMIMEType = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            AddColumn("dbo.Products", "CategoryID", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "BrandID", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "CategoryID");
            CreateIndex("dbo.Products", "BrandID");
            AddForeignKey("dbo.Products", "BrandID", "dbo.Brands", "BrandID", cascadeDelete: true);
            AddForeignKey("dbo.Products", "CategoryID", "dbo.Categories", "CategoryID", cascadeDelete: true);
            DropColumn("dbo.Products", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Category", c => c.String());
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Products", "BrandID", "dbo.Brands");
            DropForeignKey("dbo.Brands", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Brands", new[] { "CategoryID" });
            DropIndex("dbo.Products", new[] { "BrandID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropColumn("dbo.Products", "BrandID");
            DropColumn("dbo.Products", "CategoryID");
            DropTable("dbo.Categories");
            DropTable("dbo.Brands");
        }
    }
}
