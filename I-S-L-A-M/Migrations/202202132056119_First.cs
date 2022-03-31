namespace I_S_L_A_M.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Products",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Cat_id = c.Int(nullable: false),
                    Product_code = c.Int(nullable: false),
                    Name = c.String(),
                    Production_Date = c.DateTime(nullable: false),
                    Expire_Date = c.DateTime(nullable: false),
                    Price = c.Single(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Cat_id, cascadeDelete: true)
                .Index(t => t.Cat_id);

            CreateTable(
                "dbo.CustProdBills",
                c => new
                {
                    Pro_ID = c.Int(nullable: false),
                    Cust_ID = c.Int(nullable: false),
                    Cust_Bill_ID = c.Int(nullable: false),
                    Total_Price = c.Single(nullable: false),
                    Quantity = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Pro_ID, t.Cust_ID, t.Cust_Bill_ID })
                .ForeignKey("dbo.Customers", t => t.Cust_ID, cascadeDelete: true)
                .ForeignKey("dbo.CustomerBILLs", t => t.Cust_Bill_ID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Pro_ID, cascadeDelete: true)
                .Index(t => t.Pro_ID)
                .Index(t => t.Cust_ID)
                .Index(t => t.Cust_Bill_ID);

            CreateTable(
                "dbo.Customers",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Frist_Name = c.String(),
                    Last_Name = c.String(),
                    Address = c.String(),
                    Phone = c.String(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.CustomerBILLs",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Date = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.ProductStores",
                c => new
                {
                    Pro_ID = c.Int(nullable: false),
                    Store_ID = c.Int(nullable: false),
                    Quantity = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Pro_ID, t.Store_ID })
                .ForeignKey("dbo.Products", t => t.Pro_ID, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.Store_ID, cascadeDelete: true)
                .Index(t => t.Pro_ID)
                .Index(t => t.Store_ID);

            CreateTable(
                "dbo.Stores",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Address = c.String(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.SuppProdBills",
                c => new
                {
                    Pro_ID = c.Int(nullable: false),
                    Sup_ID = c.Int(nullable: false),
                    Sup_Bill_ID = c.Int(nullable: false),
                    Total_Price = c.Single(nullable: false),
                    Quantity = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Pro_ID, t.Sup_ID, t.Sup_Bill_ID })
                .ForeignKey("dbo.Products", t => t.Pro_ID, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.Sup_ID, cascadeDelete: true)
                .ForeignKey("dbo.SupplierBills", t => t.Sup_Bill_ID, cascadeDelete: true)
                .Index(t => t.Pro_ID)
                .Index(t => t.Sup_ID)
                .Index(t => t.Sup_Bill_ID);

            CreateTable(
                "dbo.Suppliers",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Email = c.String(),
                    Adderss = c.String(),
                    Phone = c.String(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.SupplierBills",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Date = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.VendProdBills",
                c => new
                {
                    Pro_ID = c.Int(nullable: false),
                    Vend_ID = c.Int(nullable: false),
                    Vend_Bill_ID = c.Int(nullable: false),
                    Total_Price = c.Single(nullable: false),
                    Paid = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Quantity = c.Int(nullable: false),
                    Stars = c.Byte(nullable: false),
                })
                .PrimaryKey(t => new { t.Pro_ID, t.Vend_ID, t.Vend_Bill_ID })
                .ForeignKey("dbo.Products", t => t.Pro_ID, cascadeDelete: true)
                .ForeignKey("dbo.Vendors", t => t.Vend_ID, cascadeDelete: true)
                .ForeignKey("dbo.VendorBILLs", t => t.Vend_Bill_ID, cascadeDelete: true)
                .Index(t => t.Pro_ID)
                .Index(t => t.Vend_ID)
                .Index(t => t.Vend_Bill_ID);

            CreateTable(
                "dbo.Vendors",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Email = c.String(),
                    City = c.String(),
                    Adderss = c.String(),
                    Phone = c.String(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.VendorBILLs",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Date = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.ID);
        }

        public override void Down()
        {
            DropForeignKey("dbo.VendProdBills", "Vend_Bill_ID", "dbo.VendorBILLs");
            DropForeignKey("dbo.VendProdBills", "Vend_ID", "dbo.Vendors");
            DropForeignKey("dbo.VendProdBills", "Pro_ID", "dbo.Products");
            DropForeignKey("dbo.SuppProdBills", "Sup_Bill_ID", "dbo.SupplierBills");
            DropForeignKey("dbo.SuppProdBills", "Sup_ID", "dbo.Suppliers");
            DropForeignKey("dbo.SuppProdBills", "Pro_ID", "dbo.Products");
            DropForeignKey("dbo.ProductStores", "Store_ID", "dbo.Stores");
            DropForeignKey("dbo.ProductStores", "Pro_ID", "dbo.Products");
            DropForeignKey("dbo.CustProdBills", "Pro_ID", "dbo.Products");
            DropForeignKey("dbo.CustProdBills", "Cust_Bill_ID", "dbo.CustomerBILLs");
            DropForeignKey("dbo.CustProdBills", "Cust_ID", "dbo.Customers");
            DropForeignKey("dbo.Products", "Cat_id", "dbo.Categories");
            DropIndex("dbo.VendProdBills", new[] { "Vend_Bill_ID" });
            DropIndex("dbo.VendProdBills", new[] { "Vend_ID" });
            DropIndex("dbo.VendProdBills", new[] { "Pro_ID" });
            DropIndex("dbo.SuppProdBills", new[] { "Sup_Bill_ID" });
            DropIndex("dbo.SuppProdBills", new[] { "Sup_ID" });
            DropIndex("dbo.SuppProdBills", new[] { "Pro_ID" });
            DropIndex("dbo.ProductStores", new[] { "Store_ID" });
            DropIndex("dbo.ProductStores", new[] { "Pro_ID" });
            DropIndex("dbo.CustProdBills", new[] { "Cust_Bill_ID" });
            DropIndex("dbo.CustProdBills", new[] { "Cust_ID" });
            DropIndex("dbo.CustProdBills", new[] { "Pro_ID" });
            DropIndex("dbo.Products", new[] { "Cat_id" });
            DropTable("dbo.VendorBILLs");
            DropTable("dbo.Vendors");
            DropTable("dbo.VendProdBills");
            DropTable("dbo.SupplierBills");
            DropTable("dbo.Suppliers");
            DropTable("dbo.SuppProdBills");
            DropTable("dbo.Stores");
            DropTable("dbo.ProductStores");
            DropTable("dbo.CustomerBILLs");
            DropTable("dbo.Customers");
            DropTable("dbo.CustProdBills");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}