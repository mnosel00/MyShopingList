namespace MyShopingList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foreignKeyFixed : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "ShoppingList_Id1", "dbo.ShoppingLists");
            DropIndex("dbo.Products", new[] { "ShoppingList_Id1" });
            RenameColumn(table: "dbo.Products", name: "ShoppingList_Id1", newName: "ShoppingListId");
            AlterColumn("dbo.Products", "ShoppingListId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "ShoppingListId");
            AddForeignKey("dbo.Products", "ShoppingListId", "dbo.ShoppingLists", "Id", cascadeDelete: true);
            DropColumn("dbo.Products", "ShoppingList_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ShoppingList_Id", c => c.Int(nullable: false));
            DropForeignKey("dbo.Products", "ShoppingListId", "dbo.ShoppingLists");
            DropIndex("dbo.Products", new[] { "ShoppingListId" });
            AlterColumn("dbo.Products", "ShoppingListId", c => c.Int());
            RenameColumn(table: "dbo.Products", name: "ShoppingListId", newName: "ShoppingList_Id1");
            CreateIndex("dbo.Products", "ShoppingList_Id1");
            AddForeignKey("dbo.Products", "ShoppingList_Id1", "dbo.ShoppingLists", "Id");
        }
    }
}
