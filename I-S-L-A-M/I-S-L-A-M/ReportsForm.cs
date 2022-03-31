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

        private void button1_Click(object sender, EventArgs e)
        {
            var AllItems = from p in context.Products
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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AllItems.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = SelledItems.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var arlist1 = new ArrayList();

            var query = from item in context.Products
                        select new { item.ID, item.Name, item.Production_Date, item.Expire_Date };

            //?handling it with query for the Performance
            foreach (var item in query)
            {
                var d = DateTime.Compare(item.Production_Date, item.Expire_Date);
                if (d > 0)
                {
                    arlist1.Add(item);
                }
            }
            dataGridView1.DataSource = arlist1;
        }

        private void button4_Click(object sender, EventArgs e)
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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ShowBillCustomers.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ShowBillSuppliers.ToList();
        }
    }
}