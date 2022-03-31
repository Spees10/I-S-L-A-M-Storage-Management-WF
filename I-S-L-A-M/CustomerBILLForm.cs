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

            var CustProdBill = from Sb in context.CustomerBILLs
                               join Spb in context.CustProdBill
                               on Sb.ID equals Spb.Cust_Bill_ID
                               join p in context.Products
                               on Spb.Pro_ID equals p.ID
                               join S in context.Customers
                               on CustomerID equals S.ID
                               where Spb.Cust_ID == CustomerID
                               select new
                               {
                                   Spb.Cust_Bill_ID,
                                   FullName = S.Frist_Name + "," + S.Last_Name,
                                   S.Address,
                                   S.Phone,
                                   Sb.Date,
                                   ProductName = p.Name,
                                   p.Price,
                                   Spb.Quantity,
                                   Spb.Total_Price
                               };
            dataGridView1.QueryDataSource(CustProdBill);
            context.SaveChanges();
        }

        private void CustomerBILLForm_Load(object sender, EventArgs e)
        {
            dataGridView1.StyleDatagridview();
        }
    }
}