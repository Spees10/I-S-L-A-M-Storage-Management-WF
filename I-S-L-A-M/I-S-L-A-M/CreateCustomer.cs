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
    public partial class CreateCustomer : Form
    {
        private Context context;
        private int CustID;

        public CreateCustomer()
        {
            InitializeComponent();
            context = new Context();
            var Q1 = from d in context.Customers
                     select d;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Q1.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.Frist_Name = textBox1.Text;
            cust.Last_Name = textBox2.Text;
            cust.Address = textBox3.Text;
            cust.Phone = textBox4.Text;
            context.Customers.Add(cust);
            context.SaveChanges();
            var Q2 = from d in context.Customers
                     select d;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Q2.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer Cust = context.Customers.Where(s => s.ID == CustID).FirstOrDefault();

            Cust.Frist_Name = textBox1.Text;
            Cust.Last_Name = textBox2.Text;
            Cust.Address = textBox3.Text;
            Cust.Phone = textBox4.Text;

            var query = from C in context.Customers
                        where C.ID == CustID
                        select C;
            context.SaveChanges();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = query.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var query = (from Cust in context.Customers
                             where Cust.ID == CustID
                             select Cust).FirstOrDefault();
                context.Customers.Remove(query);
                context.SaveChanges();
                var cust = from d in context.Customers
                           select d;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = cust.ToList();
            }
            catch
            {
                MessageBox.Show("Cannot Delete This Customer");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CustID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}