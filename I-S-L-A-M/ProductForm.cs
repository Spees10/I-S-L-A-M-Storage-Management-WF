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
        public void ClearTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            QuantityNumeric.Value = 0;
        }

        public ProductForm()
        {
            InitializeComponent();
            context = new Context();
            IntilazeData();
            SAVE1.Visible = true;
            SAVE2.Visible = false;
            textBox4.Visible = false;
            label10.Visible = false;
            comboBox1.Visible = false;
            Query();
        }

        private Context context;
        private int BranchID;
        private int CategoryID;
        private int SupplierID;
        private int P_ID;
        private SupplierBill suppBill;
        private int AntherBranchID;

        public void Query()
        {
            var ProdStore = from ps in context.ProdStore
                            join p in context.Products
                            on ps.Pro_ID equals p.ID
                            where BranchID == ps.Store_ID && p.Cat_id == CategoryID
                            select new
                            {
                                p.ID,
                                p.Product_code,
                                p.Cat_id,
                                p.Name,
                                p.Price,
                                ps.Quantity,
                                p.Production_Date,
                                p.Expire_Date,
                            };

            dataGridView1.QueryDataSource(ProdStore);
        }

        public void IntilazeData()
        {
            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.ValueMember = "ID";
            CategoryComboBox.DataSource = context.Categories.Select(c => new { c.Name, c.ID }).ToList();

            SupplierComboBox.DisplayMember = "Name";
            SupplierComboBox.ValueMember = "ID";
            SupplierComboBox.DataSource = context.Suppliers.Select(s => new { s.Name, s.ID }).ToList();

            BranchComboBox.DisplayMember = "Name";
            BranchComboBox.ValueMember = "ID";
            BranchComboBox.DataSource = context.Stores.Select(b => new { b.Name, b.ID }).ToList();

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = context.Stores.Select(b => new { b.Name, b.ID }).ToList();
        }

        public void IFExist()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            Product product = new Product();
            ProductStore prodStore = new ProductStore();
            SuppProdBill suppProdBill = new SuppProdBill();
            suppBill = new SupplierBill();

            if (textBox1.Text.IsValidString() && textBox2.Text.IsValidNum() && textBox3.Text.IsValidNum())
            {
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

                context.SaveChanges();

                Query();

                string message = "Do you want to Add Again?";
                string title = "Adding Again";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SAVE1.Visible = false;
                    SAVE2.Visible = true;
                }
                else
                {
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        public void IFNotExist()
        {
            CategoryID = int.Parse(CategoryComboBox.SelectedValue.ToString());
            SupplierID = int.Parse(SupplierComboBox.SelectedValue.ToString());

            SuppProdBill suppProdBill = new SuppProdBill();
            SupplierBill suppBill = new SupplierBill();

            Product prod = context.Products.Where(p => p.ID == P_ID).FirstOrDefault();
            if (textBox3.Text.IsValidNum())
            {
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

                Query();
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        public void OneBillProducts()
        {
            if (textBox1.Text.IsValidString() && textBox2.Text.IsValidNum() && textBox3.Text.IsValidNum())
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

                dataGridView1.QueryDataSource(context.ProductQ(CategoryID));
                context.SaveChanges();

                Query();

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
                    SAVE1.Visible = true;
                    SAVE2.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void Save1(object sender, EventArgs e)
        {
            BranchID = int.Parse(BranchComboBox.SelectedValue.ToString());
            CategoryID = int.Parse(CategoryComboBox.SelectedValue.ToString());
            SupplierID = int.Parse(SupplierComboBox.SelectedValue.ToString());

            if (New.Checked)
            {
                IFExist();
            }
            else if (Exist.Checked)
            {
                IFNotExist();
            }
            else
            {
                P_ID = int.Parse(textBox4.Text);
                AntherBranchID = int.Parse(comboBox1.SelectedValue.ToString());
                ProductStore prodStore3 = new ProductStore();
                SuppProdBill suppProdBill = new SuppProdBill();
                suppBill = new SupplierBill();

                if (textBox1.Text.IsValidString())
                {
                    suppBill.Date = DateTime.Now;

                    prodStore3.Quantity = Decimal.ToInt32(QuantityNumeric.Value);
                    prodStore3.Store_ID = AntherBranchID;
                    prodStore3.Pro_ID = P_ID;

                    suppProdBill.Sup_Bill_ID = suppBill.ID;
                    suppProdBill.Pro_ID = P_ID;
                    suppProdBill.Sup_ID = SupplierID;
                    suppProdBill.Quantity = Decimal.ToInt32(QuantityNumeric.Value);
                    suppProdBill.Total_Price = prodStore3.Quantity * decimal.Parse(textBox3.Text);

                    context.ProdStore.Add(prodStore3);
                    context.SupplierBills.Add(suppBill);
                    context.SuppProdBill.Add(suppProdBill);

                    context.SaveChanges();
                    Query();
                }
                ClearTextBox();
            }
        }

        private void Save2(object sender, EventArgs e)
        {
            OneBillProducts();
            ClearTextBox();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryID = int.Parse(CategoryComboBox.SelectedValue.ToString());
            Query();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Production.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Expired.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            dataGridView1.StyleDatagridview();
        }

        private void New_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox4.Visible = false;
            label10.Visible = false;
        }

        private void Exist_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox4.Visible = false;
            label10.Visible = false;
            textBox4.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            textBox3.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void BranchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BranchID = int.Parse(BranchComboBox.SelectedValue.ToString());
            Query();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AntherBranchID = int.Parse(comboBox1.SelectedValue.ToString());
        }
    }
}