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
    public partial class SupplierBillForm : Form
    {
        private Context context;
        private int SupplierID;

        public SupplierBillForm()
        {
            InitializeComponent();
            context = new Context();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = context.Suppliers.Select(c => new { c.Name, c.ID }).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SupplierID = int.Parse(comboBox1.SelectedValue.ToString());

            var SuppProdBill = from Spb in context.SuppProdBill
                               join Sb in context.SupplierBills
                               on Spb.Sup_Bill_ID equals Sb.ID
                               join c in context.Suppliers
                               on Spb.Sup_ID equals SupplierID
                               join p in context.Products
                               on Spb.Pro_ID equals p.ID
                               select new
                               {
                                   Spb.Sup_Bill_ID,
                                   c.Name,
                                   c.Email,
                                   c.Phone,
                                   Sb.Date,
                                   ProductName = p.Name,
                                   p.Price,
                                   Spb.Quantity,
                                   Spb.Total_Price
                               };
            context.SaveChanges();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = SuppProdBill.ToList();
        }
    }
}