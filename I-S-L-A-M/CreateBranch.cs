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
    public partial class CreateBranch : Form
    {
        private Context context;

        public CreateBranch()
        {
            InitializeComponent();
            context = new Context();
            dataGridView1.QueryDataSource(context.BranchQ());
        }

        private void AddBrnch(object sender, EventArgs e)
        {
            Store branch = new Store();
            if (textBox1.Text.IsValidString())
            {
                branch.Name = textBox1.Text;
                branch.Address = textBox2.Text;
                context.Stores.Add(branch);
                context.SaveChanges();
                dataGridView1.QueryDataSource(context.BranchQ());
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void CreateBranch_Load(object sender, EventArgs e)
        {
            dataGridView1.StyleDatagridview();
        }
    }
}