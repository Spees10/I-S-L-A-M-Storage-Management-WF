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
            dataGridView1.QueryDataSource(context.CategoryQ());
        }

        private void AddCat(object sender, EventArgs e)
        {
            Category catogery = new Category();
            if (textBox1.Text.IsValidString())
            {
                catogery.Name = textBox1.Text;
                context.Categories.Add(catogery);
                context.SaveChanges();
                textBox1.Text = "";
                dataGridView1.QueryDataSource(context.CategoryQ());
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            dataGridView1.StyleDatagridview();
        }
    }
}