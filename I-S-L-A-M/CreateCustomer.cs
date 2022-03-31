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
        public void ClearTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private Context context;
        private int CustID;

        public CreateCustomer()
        {
            InitializeComponent();
            context = new Context();

            dataGridView1.QueryDataSource(context.CustomerQ());
        }

        private void AddCust(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            if (textBox1.Text.IsValidString() && textBox2.Text.IsValidString() && textBox4.Text.IsValidPhone())
            {
                cust.Frist_Name = textBox1.Text;
                cust.Last_Name = textBox2.Text;
                cust.Address = textBox3.Text;
                cust.Phone = textBox4.Text;
                context.Customers.Add(cust);
                context.SaveChanges();
                ClearTextBox();
                dataGridView1.QueryDataSource(context.CustomerQ());
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void UpdateCust(object sender, EventArgs e)
        {
            Customer Cust = context.Customers.Where(s => s.ID == CustID).FirstOrDefault();

            if (textBox1.Text.IsValidString() && textBox2.Text.IsValidString() && textBox4.Text.IsValidPhone())
            {
                Cust.Frist_Name = textBox1.Text;
                Cust.Last_Name = textBox2.Text;
                Cust.Address = textBox3.Text;
                Cust.Phone = textBox4.Text;

                dataGridView1.QueryDataSource(context.CustomerQ());
                context.SaveChanges();
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void DeleteCust(object sender, EventArgs e)
        {
            try
            {
                var query = (from Cust in context.Customers
                             where Cust.ID == CustID
                             select Cust).FirstOrDefault();
                context.Customers.Remove(query);
                context.SaveChanges();
                dataGridView1.QueryDataSource(context.CustomerQ());
                ClearTextBox();
            }
            catch
            {
                MessageBox.Show("Cannot Delete This Customer");
                ClearTextBox();
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

        private void CreateCustomer_Load(object sender, EventArgs e)
        {
            dataGridView1.StyleDatagridview();
        }
    }
}