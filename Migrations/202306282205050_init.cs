namespace MyShopingList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Category = c.String(),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Unit = c.String(),
                        ShoppingList_Id = c.Int(nullable: false),
                        ShoppingList_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShoppingLists", t => t.ShoppingList_Id1)
                .Index(t => t.ShoppingList_Id1);
            
            CreateTable(
                "dbo.ShoppingLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsObsolate = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ShoppingList_Id1", "dbo.ShoppingLists");
            DropIndex("dbo.Products", new[] { "ShoppingList_Id1" });
            DropTable("dbo.ShoppingLists");
            DropTable("dbo.Products");
        }
    }
}
