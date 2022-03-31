namespace I_S_L_A_M.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class RestMoney : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VendProdBills", "Rest", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }

        public override void Down()
        {
            DropColumn("dbo.VendProdBills", "Rest");
        }
    }
}