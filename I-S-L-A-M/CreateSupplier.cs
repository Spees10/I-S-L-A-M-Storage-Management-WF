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
    public partial class CreateSupplier : Form
    {
        public void ClearTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private Context context;
        private int SupplierID;

        public CreateSupplier()
        {
            InitializeComponent();
            context = new Context();

            dataGridView1.QueryDataSource(context.SupplierQ());
        }

        private void AddSupp(object sender, EventArgs e)
        {
            Supplier supp = new Supplier();
            if (textBox1.Text.IsValidString() && textBox2.Text.IsValidEmail() && textBox4.Text.IsValidPhone())
            {
                supp.Name = textBox1.Text;
                supp.Email = textBox2.Text;
                supp.Adderss = textBox3.Text;
                supp.Phone = textBox4.Text;
                context.Suppliers.Add(supp);
                context.SaveChanges();

                dataGridView1.QueryDataSource(context.SupplierQ());
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void UpdateSupp(object sender, EventArgs e)
        {
            Supplier Sup = context.Suppliers.Where(s => s.ID == SupplierID).FirstOrDefault();
            if (textBox1.Text.IsValidString() && textBox2.Text.IsValidEmail() && textBox4.Text.IsValidPhone())
            {
                Sup.Name = textBox1.Text;
                Sup.Adderss = textBox3.Text;
                Sup.Email = textBox2.Text;
                Sup.Phone = textBox4.Text;

                context.SaveChanges();
                ClearTextBox();
                dataGridView1.QueryDataSource(context.SupplierQ());
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void DeleteSupp(object sender, EventArgs e)
        {
            try
            {
                var query = (from Sup in context.Suppliers
                             where Sup.ID == SupplierID
                             select Sup).FirstOrDefault();
                context.Suppliers.Remove(query);
                context.SaveChanges();
                ClearTextBox();
                dataGridView1.QueryDataSource(context.SupplierQ());
            }
            catch
            {
                MessageBox.Show("Cannot Delete This Supplier");
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SupplierID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void CreateSupplier_Load(object sender, EventArgs e)
        {
            dataGridView1.StyleDatagridview();
        }
    }
}