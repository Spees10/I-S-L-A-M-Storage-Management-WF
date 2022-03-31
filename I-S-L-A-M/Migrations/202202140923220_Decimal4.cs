namespace I_S_L_A_M.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Decimal4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustProdBills", "Total_Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }

        public override void Down()
        {
            AlterColumn("dbo.CustProdBills", "Total_Price", c => c.Single(nullable: false));
        }
    }
}