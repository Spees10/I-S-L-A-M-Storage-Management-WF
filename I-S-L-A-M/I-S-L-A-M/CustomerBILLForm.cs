using System;
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
    public partial class CustomerBILLForm : Form
    {
        private Context context;
        private int CustomerID;

        public CustomerBILLForm()
        {
            InitializeComponent();
            context = new Context();
            comboBox1.DisplayMember = "Frist_Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = context.Customers.Select(c => new { c.Frist_Name, c.ID }).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerID = int.Parse(comboBox1.SelectedValue.ToString());

            //var Cust = from c in context.Customers
            //           where c.ID == CustomerID
            //           select new { c.Frist_Name, c.Last_Name, c.Address, c.Phone };

            var CustProdBill = from cpb in context.CustProdBill
                               join cb in context.CustomerBILLs
                               on cpb.Cust_Bill_ID equals cb.ID
                               join c in context.Customers
                               on cpb.Cust_ID equals CustomerID
                               join p in context.Products
                               on cpb.Pro_ID equals p.ID
                               select new
                               {
                                   c.Frist_Name,
                                   c.Last_Name,
                                   c.Address,
                                   c.Phone,
                                   cb.Date,
                                   p.Name,
                                   p.Price,
                                   cpb.Quantity,
                                   cpb.Total_Price
                               };
            context.SaveChanges();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = CustProdBill.ToList();
        }
    }
}