namespace Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        NameOfCategory = c.String(nullable: false, maxLength: 100),
                        DescriptionOfCategory = c.String(nullable: false),
                        NameOfIconFile = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        TitleOfCourse = c.String(nullable: false, maxLength: 100),
                        AuthorOfCourse = c.String(nullable: false, maxLength: 100),
                        AddedDate = c.DateTime(nullable: false),
                        NameOfPictureFile = c.String(maxLength: 100),
                        DescriptionOfCourse = c.String(),
                        PriceOfCourse = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Bestseller = c.Boolean(nullable: false),
                        Hided = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.ItemOrder",
                c => new
                    {
                        ItemOrderId = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        PriceOfItemOrder = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ItemOrderId)
                .ForeignKey("dbo.Course", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Order", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Street = c.String(nullable: false, maxLength: 100),
                        City = c.String(nullable: false, maxLength: 100),
                        PostCode = c.String(nullable: false, maxLength: 6),
                        Telephone = c.String(),
                        Email = c.String(),
                        Comment = c.String(),
                        AddedDate = c.DateTime(nullable: false),
                        OrderStatus = c.Int(nullable: false),
                        OrderPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemOrder", "OrderId", "dbo.Order");
            DropForeignKey("dbo.ItemOrder", "CourseId", "dbo.Course");
            DropForeignKey("dbo.Course", "CategoryId", "dbo.Category");
            DropIndex("dbo.ItemOrder", new[] { "CourseId" });
            DropIndex("dbo.ItemOrder", new[] { "OrderId" });
            DropIndex("dbo.Course", new[] { "CategoryId" });
            DropTable("dbo.Order");
            DropTable("dbo.ItemOrder");
            DropTable("dbo.Course");
            DropTable("dbo.Category");
        }
    }
}
