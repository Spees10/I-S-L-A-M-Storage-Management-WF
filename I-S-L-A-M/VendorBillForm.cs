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
    public partial class VendorBillForm : Form
    {
        public void Query()
        {
            var vendprodbill = from vb in context.VendorBills
                               join vpb in context.VendProdBill
                               on vb.ID equals vpb.Vend_Bill_ID
                               join p in context.Products
                               on vpb.Pro_ID equals p.ID
                               join v in context.Vendors
                               on vendorID equals v.ID
                               where vpb.Vend_ID == vendorID
                               select new
                               {
                                   vpb.Vend_ID,
                                   v.Name,
                                   v.Email,
                                   v.Phone,
                                   ProductName = p.Name,
                                   vpb.Total_Price,
                                   vpb.Paid,
                                   vpb.Rest,
                                   v.Stars,
                                   vpb.Quantity,
                               };

            dataGridView1.QueryDataSource(vendprodbill);
        }

        private int vendorID;
        private Context context;

        public VendorBillForm()
        {
            InitializeComponent();
            context = new Context();

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = context.Vendors.Select(c => new { c.Name, c.ID }).ToList();

            Query();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            vendorID = int.Parse(comboBox1.SelectedValue.ToString());
            context.SaveChanges();
            Query();
        }

        private void VendorBillForm_Load(object sender, EventArgs e)
        {
            dataGridView1.StyleDatagridview();
        }
    }
}