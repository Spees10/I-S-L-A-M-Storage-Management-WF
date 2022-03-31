using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_S_L_A_M
{
    public partial class ReportsForm : Form
    {
        private Context context;

        public ReportsForm()
        {
            InitializeComponent();
            context = new Context();
        }

        private void AllProds(object sender, EventArgs e)
        {
            var AllProducts = from p in context.Products
                              join ps in context.ProdStore
                              on p.ID equals ps.Pro_ID
                              join cat in context.Categories
                              on p.Cat_id equals cat.ID
                              join s in context.Stores
                              on ps.Store_ID equals s.ID

                              select new
                              {
                                  p.ID,
                                  StoreName = s.Name,
                                  CategoryName = cat.Name,
                                  ProductName = p.Name,
                                  p.Price,
                                  ps.Quantity,
                                  p.Production_Date,
                                  p.Expire_Date,
                              };
            dataGridView1.QueryDataSource(AllProducts);
        }

        private void SoldProds(object sender, EventArgs e)
        {
            var SelledItems = from cpb in context.CustProdBill
                              join p in context.Products
                              on cpb.Pro_ID equals p.ID
                              join c in context.Customers
                              on cpb.Cust_ID equals c.ID
                              join cb in context.CustomerBILLs
                              on cpb.Cust_Bill_ID equals cb.ID
                              join cat in context.Categories
                              on p.Cat_id equals cat.ID
                              join ps in context.ProdStore
                              on p.ID equals ps.Pro_ID
                              join st in context.Stores
                              on ps.Store_ID equals st.ID

                              select new
                              {
                                  CustomerBillID = cpb.Cust_Bill_ID,
                                  ProductName = p.Name,
                                  StoreName = st.Name,
                                  CategoryName = cat.Name,
                                  CustomerFirstName = c.Frist_Name,
                                  PurshaceDate = cb.Date,
                                  ExpiredDate = p.Expire_Date,
                                  TotalPrice = cpb.Total_Price,
                                  PrushacedQuantity = cpb.Quantity
                              };
            dataGridView1.QueryDataSource(SelledItems);
        }

        private void ExpiredProds(object sender, EventArgs e)
        {
            var arrList1 = new ArrayList();

            var query = from item in context.Products
                        select new { item.ID, item.Name, item.Production_Date, item.Expire_Date };

            foreach (var item in query)
            {
                var d = DateTime.Compare(item.Production_Date, item.Expire_Date);
                if (d > 0)
                {
                    arrList1.Add(item);
                }
            }
            dataGridView1.DataSource = arrList1;
        }

        private void CustBills2(object sender, EventArgs e)
        {
            var ShowBillCustomers = from cpb in context.CustProdBill
                                    join cp in context.CustomerBILLs
                                    on cpb.Cust_Bill_ID equals cp.ID

                                    select new
                                    {
                                        cp.ID,
                                        cp.Date,
                                        cpb.Total_Price,
                                        cpb.Quantity,
                                    };
            dataGridView1.QueryDataSource(ShowBillCustomers);
        }

        private void SuppBills2(object sender, EventArgs e)
        {
            var ShowBillSuppliers = from spb in context.SuppProdBill
                                    join sb in context.SupplierBills
                                    on spb.Sup_Bill_ID equals sb.ID

                                    select new
                                    {
                                        sb.ID,
                                        sb.Date,
                                        spb.Total_Price,
                                        spb.Quantity,
                                    };
            dataGridView1.QueryDataSource(ShowBillSuppliers);
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.StyleDatagridview();
        }

        private void VendorBills_Click(object sender, EventArgs e)
        {
            var ShowVendorBill = from vpb in context.VendProdBill
                                 join vb in context.VendorBills
                                 on vpb.Vend_Bill_ID equals vb.ID
                                 join v in context.Vendors
                                 on vpb.Vend_ID equals v.ID
                                 join p in context.Products
                                 on vpb.Pro_ID equals p.ID

                                 select new
                                 {
                                     v.ID,
                                     v.Name,
                                     v.Email,
                                     v.Phone,
                                     v.Stars,
                                     ProuductName = p.Name,
                                     vpb.Quantity,
                                     vpb.Paid,
                                     vpb.Rest,
                                     vb.Date
                                 };
            dataGridView1.QueryDataSource(ShowVendorBill);
        }

        private void ExpireSoon_Click(object sender, EventArgs e)
        {
            var AllProducts = from p in context.Products
                              join ps in context.ProdStore
                              on p.ID equals ps.Pro_ID
                              where ps.Quantity < 10
                              join cat in context.Categories
                              on p.Cat_id equals cat.ID
                              join s in context.Stores
                              on ps.Store_ID equals s.ID

                              select new
                              {
                                  p.ID,
                                  StoreName = s.Name,
                                  CategoryName = cat.Name,
                                  ProductName = p.Name,
                                  p.Price,
                                  ps.Quantity,
                                  p.Production_Date,
                                  p.Expire_Date,
                              };
            dataGridView1.QueryDataSource(AllProducts);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var date_month = dateTimePicker1.Value.Month;
            var date_year = dateTimePicker1.Value.Year;
            var ShowBillSuppliers = from spb in context.SuppProdBill
                                    join sb in context.SupplierBills
                                    on spb.Sup_Bill_ID equals sb.ID
                                    join p in context.Products
                                    on spb.Pro_ID equals p.ID
                                    where p.Production_Date.Month == date_month && p.Production_Date.Year == date_year
                                    select new
                                    {
                                        p.ID,
                                        p.Product_code,
                                        ProductName = p.Name,
                                        p.Price,
                                        p.Expire_Date
                                    };
            dataGridView1.QueryDataSource(ShowBillSuppliers);
        }
    }
}