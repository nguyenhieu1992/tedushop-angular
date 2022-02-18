namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class x2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Quantity", c => c.Int());
            AddColumn("dbo.Products", "OriginalPrice", c => c.Decimal());
        }
        
        public override void Down()
        {
        }
    }
}
