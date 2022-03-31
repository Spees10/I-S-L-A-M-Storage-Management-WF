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
    public partial class SellProductForm : Form
    {
        public SellProductForm()
        {
            InitializeComponent();
            context = new Context();

            SellProduct.Visible = true;
            SellProduct2.Visible = false;

            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.ValueMember = "ID";
            CategoryComboBox.DataSource = context.Categories.Select(c => new { c.Name, c.ID }).ToList();

            CustomerComboBox.DisplayMember = "Frist_Name";
            CustomerComboBox.ValueMember = "ID";
            CustomerComboBox.DataSource = context.Customers.Select(c => new { c.Frist_Name, c.ID }).ToList();

            BranchComboBox.DisplayMember = "Name";
            BranchComboBox.ValueMember = "ID";
            BranchComboBox.DataSource = context.Stores.Select(b => new { b.Name, b.ID }).ToList();

            Query();
        }

        private Context context;
        private int BranchID;
        private int CategoryID;
        private int CustomerID;
        private int P_ID;
        private int StoreID;
        private CustomerBILL customerBills;

        public void Query()
        {
            var ProdStore = from ps in context.ProdStore
                            join p in context.Products
                            on ps.Pro_ID equals p.ID
                            where StoreID == ps.Store_ID && p.Cat_id == CategoryID
                            select new
                            {
                                p.ID,
                                p.Cat_id,
                                ps.Store_ID,
                                p.Name,
                                p.Price,
                                ps.Quantity,
                                p.Production_Date,
                                p.Expire_Date,
                            };
            dataGridView1.QueryDataSource(ProdStore);
        }

        public void ClearTextBox()
        {
            Name1.Clear();
            Price.Clear();
            QuantityNumeric.Value = 0;
        }

        private void SellProd(object sender, EventArgs e)
        {
            BranchID = int.Parse(BranchComboBox.SelectedValue.ToString());
            CategoryID = int.Parse(CategoryComboBox.SelectedValue.ToString());
            CustomerID = int.Parse(CustomerComboBox.SelectedValue.ToString());
            int SelledQuantity = Decimal.ToInt32(QuantityNumeric.Value);

            CustProdBill custProdBill = new CustProdBill();
            customerBills = new CustomerBILL();

            Product prod = context.Products.Where(p => p.ID == P_ID).FirstOrDefault();
            prod.Price = decimal.Parse(Price.Text);
            ProductStore prodStore = context.ProdStore.Where(p => p.Pro_ID == P_ID && p.Store_ID == BranchID).FirstOrDefault();
            int OldQun = prodStore.Quantity;

            if (SelledQuantity <= OldQun)
            {
                if (OldQun == 0)
                {
                    MessageBox.Show($"There is no {prod.Name} int the Stock");
                }
                else if (SelledQuantity == 0)
                {
                    MessageBox.Show($"You Entered 0 Quantity");
                }
                else
                {
                    prodStore.Quantity = OldQun - SelledQuantity;
                    customerBills.Date = DateTime.Now;

                    custProdBill.Cust_Bill_ID = customerBills.ID;
                    custProdBill.Pro_ID = P_ID;
                    custProdBill.Cust_ID = CustomerID;
                    custProdBill.Quantity = SelledQuantity;
                    decimal price = decimal.Parse(Price.Text);
                    custProdBill.Total_Price = SelledQuantity * price;

                    context.CustomerBILLs.Add(customerBills);
                    context.CustProdBill.Add(custProdBill);
                    context.SaveChanges();

                    //?refreshing
                    Query();

                    string message = "Do you want to Sell Again?";
                    string title = "Selling Again";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        SellProduct.Visible = false;
                        SellProduct2.Visible = true;
                    }
                    else
                    {
                        //
                    }
                }
            }
            else
            {
                MessageBox.Show("Quantity Not Enough");
            }
        }

        private void SellProduct2_Click(object sender, EventArgs e)
        {
            OneBillProducts();
            ClearTextBox();
        }

        public void OneBillProducts()
        {
            BranchID = int.Parse(BranchComboBox.SelectedValue.ToString());
            CategoryID = int.Parse(CategoryComboBox.SelectedValue.ToString());
            CustomerID = int.Parse(CustomerComboBox.SelectedValue.ToString());
            int SelledQuantity = Decimal.ToInt32(QuantityNumeric.Value);

            CustProdBill custProdBill2 = new CustProdBill();
            Product prod2 = context.Products.Where(p => p.ID == P_ID).FirstOrDefault();

            ProductStore prodStore2 = context.ProdStore.Where(p => p.Pro_ID == P_ID && p.Store_ID == BranchID).FirstOrDefault();
            int OldQun = prodStore2.Quantity;

            if (SelledQuantity <= OldQun)
            {
                if (OldQun == 0)
                {
                    MessageBox.Show($"There is no {prod2.Name} int the Stock");
                }
                else if (SelledQuantity == 0)
                {
                    MessageBox.Show($"You Entered 0 Quantity");
                }
                else
                {
                    prodStore2.Quantity = OldQun - SelledQuantity;

                    custProdBill2.Cust_Bill_ID = customerBills.ID;
                    custProdBill2.Pro_ID = P_ID;
                    custProdBill2.Cust_ID = CustomerID;
                    custProdBill2.Quantity = SelledQuantity;
                    decimal price = decimal.Parse(Price.Text);
                    custProdBill2.Total_Price = SelledQuantity * price;

                    context.CustProdBill.Add(custProdBill2);

                    context.SaveChanges();

                    //?refreshing
                    Query();

                    string message2 = "Do you want to Sell Again?";
                    string title2 = "Selling Again";
                    MessageBoxButtons buttons2 = MessageBoxButtons.YesNo;
                    DialogResult result2 = MessageBox.Show(message2, title2, buttons2);
                    if (result2 == DialogResult.Yes)
                    {
                        //
                    }
                    else
                    {
                        SellProduct.Visible = true;
                        SellProduct2.Visible = false;
                    }
                }

                dataGridView1.QueryDataSource(context.ProductQ(CategoryID));
                context.SaveChanges();

                Query();
            }
            else
            {
                MessageBox.Show($"Not Enough Quantity");
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryID = int.Parse(CategoryComboBox.SelectedValue.ToString());
            Query();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            P_ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Name1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Price.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void SellProductForm_Load(object sender, EventArgs e)
        {
            dataGridView1.StyleDatagridview();
        }

        private void BranchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoreID = int.Parse(BranchComboBox.SelectedValue.ToString());
            Query();
        }
    }
}