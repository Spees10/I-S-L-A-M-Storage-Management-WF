namespace I_S_L_A_M.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VendStars : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vendors", "Stars", c => c.Byte(nullable: false));
            DropColumn("dbo.VendProdBills", "Stars");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VendProdBills", "Stars", c => c.Byte(nullable: false));
            DropColumn("dbo.Vendors", "Stars");
        }
    }
}
