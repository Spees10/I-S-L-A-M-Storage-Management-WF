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

            var brnch = from d in context.Stores
                        select d;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = brnch.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Store branch = new Store();
            branch.Name = textBox1.Text;
            branch.Address = textBox2.Text;
            context.Stores.Add(branch);
            context.SaveChanges();

            var brnch = from d in context.Stores
                        select d;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = brnch.ToList();
        }
    }
}