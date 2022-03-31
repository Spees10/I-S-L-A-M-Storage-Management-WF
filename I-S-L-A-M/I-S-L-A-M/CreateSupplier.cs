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
        private Context context;
        int SuplierID;
        public CreateSupplier()
        {
            InitializeComponent();
            context = new Context();

            var Q1 = from s in context.Suppliers
                     select s;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Q1.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supplier supp = new Supplier();
            supp.Name = textBox1.Text;
            supp.Email = textBox2.Text;
            supp.Adderss = textBox3.Text;
            supp.Phone = textBox4.Text;
            context.Suppliers.Add(supp);
            context.SaveChanges();

            var Q1 = from s in context.Suppliers
                     select s;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Q1.ToList();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Supplier Sup = context.Suppliers.Where(s => s.ID == SuplierID).FirstOrDefault();

            Sup.Name = textBox1.Text;
            Sup.Adderss = textBox3.Text;
            Sup.Email = textBox2.Text;
            Sup.Phone = textBox4.Text;

            var query = from C in context.Suppliers
                        where C.ID == SuplierID
                        select C;
            context.SaveChanges();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = query.ToList();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                var query = (from Sup in context.Suppliers
                             where Sup.ID == SuplierID
                             select Sup).FirstOrDefault();
                context.Suppliers.Remove(query);
                context.SaveChanges();
                var Suplier = from d in context.Suppliers
                           select d;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Suplier.ToList();
            }
            catch
            {
                MessageBox.Show("Cannot Delete This Supplier");
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SuplierID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}