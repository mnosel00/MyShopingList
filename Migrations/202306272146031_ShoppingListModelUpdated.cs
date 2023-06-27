namespace MyShopingList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShoppingListModelUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShoppingLists", "IsObsolate", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ShoppingLists", "IsObsolate");
        }
    }
}
