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
        public void QyaryRefresh()
        {
            var SuppProdBill = from Sb in context.SupplierBills
                               join Spb in context.SuppProdBill
                               on Sb.ID equals Spb.Sup_Bill_ID
                               join p in context.Products
                               on Spb.Pro_ID equals p.ID
                               join S in context.Suppliers
                               on SupplierID equals S.ID
                               where Spb.Sup_ID == SupplierID
                               select new
                               {
                                   Spb.Sup_Bill_ID,
                                   S.Name,
                                   S.Email,
                                   S.Phone,
                                   Sb.Date,
                                   ProductName = p.Name,
                                   p.Price,
                                   Spb.Quantity,
                                   Spb.Total_Price
                               };

            dataGridView1.QueryDataSource(SuppProdBill);
        }

        private Context context;
        private int SupplierID;

        public SupplierBillForm()
        {
            InitializeComponent();
            context = new Context();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = context.Suppliers.Select(c => new { c.Name, c.ID }).ToList();

            SupplierID = int.Parse(comboBox1.SelectedValue.ToString());
            context.SaveChanges();
            QyaryRefresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SupplierID = int.Parse(comboBox1.SelectedValue.ToString());
            context.SaveChanges();
            QyaryRefresh();
        }

        private void SupplierBillForm_Load(object sender, EventArgs e)
        {
            dataGridView1.StyleDatagridview();
        }
    }
}