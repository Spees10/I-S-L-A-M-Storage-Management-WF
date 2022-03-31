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
    public partial class CreateVendor : Form
    {
        public void ClearTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private Context context;
        private int VendorID;

        public CreateVendor()
        {
            InitializeComponent();
            context = new Context();

            dataGridView1.QueryDataSource(context.VendorQ());
        }

        private void AddVend(object sender, EventArgs e)
        {
            Vendor Vend = new Vendor();
            if (textBox1.Text.IsValidString() && textBox2.Text.IsValidEmail() && textBox4.Text.IsValidPhone())
            {
                Vend.Name = textBox1.Text;
                Vend.Email = textBox2.Text;
                Vend.Adderss = textBox3.Text;
                Vend.Phone = textBox4.Text;
                Vend.City = textBox5.Text;
                context.Vendors.Add(Vend);
                context.SaveChanges();

                dataGridView1.QueryDataSource(context.VendorQ());
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void UpdateVend(object sender, EventArgs e)
        {
            Vendor Vend = context.Vendors.Where(s => s.ID == VendorID).FirstOrDefault();
            if (textBox1.Text.IsValidString() && textBox2.Text.IsValidEmail() && textBox4.Text.IsValidPhone())
            {
                Vend.Name = textBox1.Text;
                Vend.Adderss = textBox3.Text;
                Vend.Email = textBox2.Text;
                Vend.Phone = textBox4.Text;
                Vend.City = textBox5.Text;

                context.SaveChanges();
                ClearTextBox();
                dataGridView1.QueryDataSource(context.VendorQ());
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void DeleteVend(object sender, EventArgs e)
        {
            try
            {
                var queryV = (from Vend in context.Vendors
                              where Vend.ID == VendorID
                              select Vend).FirstOrDefault();
                context.Vendors.Remove(queryV);
                context.SaveChanges();
                ClearTextBox();
                dataGridView1.QueryDataSource(context.VendorQ());
            }
            catch
            {
                MessageBox.Show("Cannot Delete This Vendor");
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VendorID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void CreateVendor_Load(object sender, EventArgs e)
        {
            dataGridView1.StyleDatagridview();
        }
    }
}