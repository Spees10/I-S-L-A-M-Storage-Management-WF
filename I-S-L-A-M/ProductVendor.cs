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
    public partial class ProductVendor : Form
    {
        public ProductVendor()
        {
            InitializeComponent();
            context = new Context();

            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.ValueMember = "ID";
            CategoryComboBox.DataSource = context.Categories.Select(c => new { c.Name, c.ID }).ToList();

            VendorComboBox.DisplayMember = "Name";
            VendorComboBox.ValueMember = "ID";
            VendorComboBox.DataSource = context.Vendors.Select(c => new { c.Name, c.ID }).ToList();

            BranchComboBox.DisplayMember = "Name";
            BranchComboBox.ValueMember = "ID";
            BranchComboBox.DataSource = context.Stores.Select(b => new { b.Name, b.ID }).ToList();

            SellProduct.Visible = true;
            SellProduct2.Visible = false;

            Query();
        }

        public void ClearTextBox()
        {
            Name1.Clear();
            PriceLB.Clear();
            QuantityNumeric.Value = 0;
            PaidUp.Clear();
        }

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

        private Context context;
        private int BranchID;
        private int CategoryID;
        private int VendorID;
        private int P_ID;
        private int StoreID;
        private decimal Total;
        private decimal PriceProd;
        private VendorBILL VendBill;
        private decimal Paid;
        private Vendor Vendy;

        private void SellProduct_Click(object sender, EventArgs e)
        {
            BranchID = int.Parse(BranchComboBox.SelectedValue.ToString());
            CategoryID = int.Parse(CategoryComboBox.SelectedValue.ToString());
            VendorID = int.Parse(VendorComboBox.SelectedValue.ToString());
            decimal SelledQuantity = QuantityNumeric.Value;

            VendProdBill vendProdBill = new VendProdBill();
            VendBill = new VendorBILL();
            Vendy = context.Vendors.Where(v => v.ID == VendorID).FirstOrDefault();

            Product prod = context.Products.Where(p => p.ID == P_ID).FirstOrDefault();
            decimal Price = prod.Price;

            prod.Price = decimal.Parse(PriceLB.Text);
            ProductStore prodStore = context.ProdStore.Where(p => p.Pro_ID == P_ID && p.Store_ID == BranchID).FirstOrDefault();
            decimal OldQun = prodStore.Quantity;

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
                    prodStore.Quantity = int.Parse((OldQun - SelledQuantity).ToString());
                    VendBill.Date = DateTime.Now;

                    vendProdBill.Vend_Bill_ID = VendBill.ID;
                    vendProdBill.Pro_ID = P_ID;
                    vendProdBill.Vend_ID = VendorID;
                    vendProdBill.Quantity = int.Parse(SelledQuantity.ToString());
                    decimal price = decimal.Parse(PriceLB.Text);
                    vendProdBill.Total_Price = SelledQuantity * price;
                    Total = SelledQuantity * price;
                    vendProdBill.Paid = decimal.Parse(PaidUp.Text);
                    Paid = vendProdBill.Paid;

                    if (Paid <= Total)
                    {
                        vendProdBill.Rest = Total - Paid;
                        RestPaidLB.Text = $"Rest Money {vendProdBill.Rest}";
                        if (vendProdBill.Rest == 0)
                        {
                            Vendy.Stars++;
                            Stars.Text = $"Stars of Vendor {Vendy.Stars}";
                        }
                        context.VendorBills.Add(VendBill);
                        context.VendProdBill.Add(vendProdBill);
                        context.SaveChanges();
                        Query();
                    }
                    else if (Paid > Total)
                    {
                        MessageBox.Show("The payment is greater than the total amount");
                    }
                }
            }
            else
            {
                MessageBox.Show("Quantity Not Enough");
            }
            //?refreshing
            Query();

            string message2 = "Do you want to Sell Again?";
            string title2 = "Selling Again";
            MessageBoxButtons buttons2 = MessageBoxButtons.YesNo;
            DialogResult result2 = MessageBox.Show(message2, title2, buttons2);
            if (result2 == DialogResult.Yes)
            {
                SellProduct.Visible = false;
                SellProduct2.Visible = true;
            }
            else
            {
                //
            }
            ClearTextBox();
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
            VendorID = int.Parse(VendorComboBox.SelectedValue.ToString());
            int SelledQuantity = Decimal.ToInt32(QuantityNumeric.Value);

            VendProdBill vendProdBill2 = new VendProdBill();
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

                    vendProdBill2.Vend_Bill_ID = VendBill.ID;
                    vendProdBill2.Pro_ID = P_ID;
                    vendProdBill2.Vend_ID = VendorID;
                    vendProdBill2.Quantity = SelledQuantity;
                    decimal price = decimal.Parse(PriceLB.Text);
                    vendProdBill2.Total_Price = SelledQuantity * price;

                    if (Paid <= Total)
                    {
                        vendProdBill2.Rest = Total - Paid;
                        RestPaidLB.Text = $"Rest Money {vendProdBill2.Rest}";
                        if (vendProdBill2.Rest == 0)
                        {
                            Vendy.Stars++;
                            Stars.Text = $"Stars of Vendor {Vendy.Stars}";
                        }
                        //context.VendorBills.Add(VendBill);
                        //context.VendProdBill.Add(vendProdBill2);
                        //context.SaveChanges();
                        //Query();
                        context.VendProdBill.Add(vendProdBill2);
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
                    else if (Paid > Total)
                    {
                        MessageBox.Show("The payment is greater than the total amount");
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

        private void QuantityNumeric_ValueChanged(object sender, EventArgs e)
        {
            TotalLB.Text = $"Total Price {QuantityNumeric.Value * PriceProd}";
        }

        private void BranchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoreID = int.Parse(BranchComboBox.SelectedValue.ToString());
            Query();
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
            PriceLB.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            PriceProd = decimal.Parse(PriceLB.Text);
        }

        private void ProductVendor_Load(object sender, EventArgs e)
        {
            dataGridView1.StyleDatagridview();
        }
    }
}