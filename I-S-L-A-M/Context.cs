using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_S_L_A_M
{
    internal class Context : DbContext
    {
        public Context() : base(@"Data Source=Lenovo\LOAI;Initial Catalog=IslamDBNew;integrated security=true")
        { }

        public virtual DbSet<Customer> Customers { set; get; }
        public virtual DbSet<Product> Products { set; get; }
        public virtual DbSet<Category> Categories { set; get; }
        public virtual DbSet<Store> Stores { set; get; }
        public virtual DbSet<ProductStore> ProdStore { set; get; }
        public virtual DbSet<Supplier> Suppliers { set; get; }
        public virtual DbSet<Vendor> Vendors { set; get; }
        public virtual DbSet<SupplierBill> SupplierBills { set; get; }
        public virtual DbSet<VendorBILL> VendorBills { set; get; }
        public virtual DbSet<CustomerBILL> CustomerBILLs { set; get; }
        public virtual DbSet<CustProdBill> CustProdBill { set; get; }
        public virtual DbSet<SuppProdBill> SuppProdBill { set; get; }
        public virtual DbSet<VendProdBill> VendProdBill { set; get; }
    }
}