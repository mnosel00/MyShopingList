namespace MyShopingList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductModelChange : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
