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
    public partial class ProductForm : Form
    {
        #region Layout

        //public static void Layouts(DataGridView dataGridView1, Color BackgroundColor, Color RowsBackColor, Color AlternatebackColor, Boolean AutoGenerateColumns, Color HeaderColor, Boolean HeaderVisual, Boolean RowHeadersVisible, Boolean AllowUserToAddRows, Color HeaderForeColor, int headerHeight)
        //{
        //    //Grid Back ground Color
        //    dataGridView1.BackgroundColor = BackgroundColor;

        //    //Grid Back Color
        //    dataGridView1.RowsDefaultCellStyle.BackColor = RowsBackColor;

        //    //GridColumnStylesCollection Alternate Rows Backcolr
        //    dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = AlternatebackColor;

        //    // Auto generated here set to tru or false.
        //    dataGridView1.AutoGenerateColumns = AutoGenerateColumns;
        //    // dataGridView1.DefaultCellStyle.Font = new Font("Verdana", 10.25f, FontStyle.Regular);
        //    // dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Regular);

        //    //Column Header back Color
        //    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = HeaderColor;
        //    dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = HeaderForeColor;
        //    dataGridView1.ColumnHeadersHeight = headerHeight;
        //    //header Visisble
        //    dataGridView1.EnableHeadersVisualStyles = HeaderVisual;

        //    // Enable the row header
        //    dataGridView1.RowHeadersVisible = RowHeadersVisible;

        //    // to Hide the Last Empty row here we use false.
        //    dataGridView1.AllowUserToAddRows = AllowUserToAddRows;
        //}
        #endregion


        private Context context;
        private int BranchID;
        private int CategoryID;
        private int SupplierID;
        private int P_ID;
        SupplierBill suppBill;

        public ProductForm()
        {
            InitializeComponent();
            context = new Context();

            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.ValueMember = "ID";
            CategoryComboBox.DataSource = context.Categories.Select(c => new { c.Name, c.ID }).ToList();

            SupplierComboBox.DisplayMember = "Name";
            SupplierComboBox.ValueMember = "ID";
            SupplierComboBox.DataSource = context.Suppliers.Select(s => new { s.Name, s.ID }).ToList();

            BranchComboBox.DisplayMember = "Name";
            BranchComboBox.ValueMember = "ID";
            BranchComboBox.DataSource = context.Stores.Select(b => new { b.Name, b.ID }).ToList();

            Save2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BranchID = int.Parse(BranchComboBox.SelectedValue.ToString());
            CategoryID = int.Parse(CategoryComboBox.SelectedValue.ToString());
            SupplierID = int.Parse(SupplierComboBox.SelectedValue.ToString());

            if (New.Checked)
            {
                Product product = new Product();
                ProductStore prodStore = new ProductStore();
                SuppProdBill suppProdBill = new SuppProdBill();
                suppBill = new SupplierBill();


                product.Name = textBox1.Text;
                product.Cat_id = CategoryID;
                product.Product_code = int.Parse(textBox2.Text);
                product.Price = int.Parse(textBox3.Text);
                product.Production_Date = Convert.ToDateTime(Production.Value.ToString("yyyy-MM-dd"));
                product.Expire_Date = Convert.ToDateTime(Expired.Value.ToString("yyyy-MM-dd"));

                suppBill.Date = DateTime.Now;

                prodStore.Quantity = Decimal.ToInt32(QuantityNumeric.Value);
                prodStore.Store_ID = BranchID;
                prodStore.Pro_ID = product.ID;


                suppProdBill.Sup_Bill_ID = suppBill.ID;
                suppProdBill.Pro_ID = product.ID;
                suppProdBill.Sup_ID = SupplierID;
                suppProdBill.Quantity = prodStore.Quantity;
                suppProdBill.Total_Price = prodStore.Quantity * product.Price;

                context.Products.Add(product);
                context.ProdStore.Add(prodStore);
                context.SupplierBills.Add(suppBill);
                context.SuppProdBill.Add(suppProdBill);

                var prod = from p in context.Products
                           where p.Cat_id == CategoryID
                           select p;

                context.SaveChanges();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = prod.ToList();

                string message = "Do you want to Add Again?";
                string title = "Adding Again";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Save1.Visible = false;
                    Save2.Visible = true;
                }
                else
                {
                    //
                }
            }
            else
            {
                BranchID = int.Parse(BranchComboBox.SelectedValue.ToString());
                CategoryID = int.Parse(CategoryComboBox.SelectedValue.ToString());
                SupplierID = int.Parse(SupplierComboBox.SelectedValue.ToString());

                SuppProdBill suppProdBill = new SuppProdBill();
                SupplierBill suppBill = new SupplierBill();

                Product prod = context.Products.Where(p => p.ID == P_ID).FirstOrDefault();
                prod.Price = int.Parse(textBox3.Text);
                ProductStore prodStore = context.ProdStore.Where(p => p.Pro_ID == P_ID && p.Store_ID == BranchID).FirstOrDefault();
                int OldQun = prodStore.Quantity;
                prodStore.Quantity = OldQun + Decimal.ToInt32(QuantityNumeric.Value);

                suppBill.Date = DateTime.Now;

                suppProdBill.Sup_Bill_ID = suppBill.ID;
                suppProdBill.Pro_ID = P_ID;
                suppProdBill.Sup_ID = SupplierID;
                suppProdBill.Quantity = prodStore.Quantity;
                int price = int.Parse(textBox3.Text);
                suppProdBill.Total_Price = prodStore.Quantity * price;

                context.SupplierBills.Add(suppBill);
                context.SuppProdBill.Add(suppProdBill);
                context.SaveChanges();
            }
        }
        private void Save2_Click(object sender, EventArgs e)
        {
            Product product2 = new Product();
            ProductStore prodStore2 = new ProductStore();
            SuppProdBill suppProdBill2 = new SuppProdBill();

            product2.Name = textBox1.Text;
            product2.Cat_id = CategoryID;
            product2.Product_code = int.Parse(textBox2.Text);
            product2.Price = int.Parse(textBox3.Text);
            product2.Production_Date = Convert.ToDateTime(Production.Value.ToString("yyyy-MM-dd"));
            product2.Expire_Date = Convert.ToDateTime(Expired.Value.ToString("yyyy-MM-dd"));

            prodStore2.Quantity = Decimal.ToInt32(QuantityNumeric.Value);
            prodStore2.Store_ID = BranchID;
            prodStore2.Pro_ID = product2.ID;

            suppProdBill2.Sup_Bill_ID = suppBill.ID;
            suppProdBill2.Pro_ID = product2.ID;
            suppProdBill2.Sup_ID = SupplierID;
            suppProdBill2.Quantity = prodStore2.Quantity;
            suppProdBill2.Total_Price = prodStore2.Quantity * product2.Price;

            context.Products.Add(product2);
            context.ProdStore.Add(prodStore2);
            context.SuppProdBill.Add(suppProdBill2);

            var prod2 = from p in context.Products
                        where p.Cat_id == CategoryID
                        select p;

            context.SaveChanges();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = prod2.ToList();

            string message = "Do you want to Add Again?";
            string title = "Adding Again";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                //
            }
            else
            {
                Save2.Visible = false;
                Save1.Visible = true;
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
        }

        void StyleDatagridview()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif",14);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

    private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryID = int.Parse(CategoryComboBox.SelectedValue.ToString());
            var prod = from p in context.Products
                       where p.Cat_id == CategoryID
                       select p;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = prod.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            P_ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Production.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Expired.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

    }
}