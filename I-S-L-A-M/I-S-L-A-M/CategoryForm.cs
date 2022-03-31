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
    public partial class CategoryForm : Form
    {
        private Context context;

        public CategoryForm()
        {
            InitializeComponent();
            context = new Context();
            var categ = from d in context.Categories
                        select d;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = categ.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category catogery = new Category();
            catogery.Name = textBox1.Text;
            context.Categories.Add(catogery);
            context.SaveChanges();

            var categ = from d in context.Categories
                        select d;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = categ.ToList();
        }
    }
}