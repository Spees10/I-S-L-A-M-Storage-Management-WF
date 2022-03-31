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
        private Context context;
        private int BranchID;
        private int CategoryID;
        private int CustomerID;
        private int P_ID;

        public SellProductForm()
        {
            InitializeComponent();
            context = new Context();

            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.ValueMember = "ID";
            CategoryComboBox.DataSource = context.Categories.Select(c => new { c.Name, c.ID }).ToList();

            CustomerComboBox.DisplayMember = "Frist_Name";
            CustomerComboBox.ValueMember = "ID";
            CustomerComboBox.DataSource = context.Customers.Select(c => new { c.Frist_Name, c.ID }).ToList();

            BranchComboBox.DisplayMember = "Name";
            BranchComboBox.ValueMember = "ID";
            BranchComboBox.DataSource = context.Stores.Select(b => new { b.Name, b.ID }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BranchID = int.Parse(BranchComboBox.SelectedValue.ToString());
            CategoryID = int.Parse(CategoryComboBox.SelectedValue.ToString());
            CustomerID = int.Parse(CustomerComboBox.SelectedValue.ToString());
            int SelledQuantity = Decimal.ToInt32(QuantityNumeric.Value);

            CustProdBill custProdBill = new CustProdBill();
            CustomerBILL customerBills = new CustomerBILL();

            Product prod = context.Products.Where(p => p.ID == P_ID).FirstOrDefault();
            prod.Price = int.Parse(Price.Text);
            ProductStore prodStore = context.ProdStore.Where(p => p.Pro_ID == P_ID && p.Store_ID == BranchID).FirstOrDefault();
            int OldQun = prodStore.Quantity;

            if (SelledQuantity < OldQun)
                prodStore.Quantity = OldQun - SelledQuantity;
            else
            {
                MessageBox.Show("Quantity Not Enough");
            }

            customerBills.Date = DateTime.Now;

            custProdBill.Cust_Bill_ID = customerBills.ID;
            custProdBill.Pro_ID = P_ID;
            custProdBill.Cust_ID = CustomerID;
            custProdBill.Quantity = SelledQuantity;
            int price = int.Parse(Price.Text);
            custProdBill.Total_Price = SelledQuantity * price;

            context.CustomerBILLs.Add(customerBills);
            context.CustProdBill.Add(custProdBill);
            context.SaveChanges();

            //?refreshing
            var ProdStore = from p in context.Products
                            join ps in context.ProdStore
                            on p.ID equals ps.Pro_ID

                            select new
                            {
                                p.ID,
                                p.Cat_id,
                                p.Name,
                                p.Price,
                                ps.Quantity,
                                p.Production_Date,
                                p.Expire_Date,
                            };
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ProdStore.ToList();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryID = int.Parse(CategoryComboBox.SelectedValue.ToString());

            var ProdStore = from p in context.Products
                            join ps in context.ProdStore
                            on p.ID equals ps.Pro_ID

                            select new
                            {
                                p.ID,
                                p.Cat_id,
                                p.Name,
                                p.Price,
                                ps.Quantity,
                                p.Production_Date,
                                p.Expire_Date,
                            };
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ProdStore.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            P_ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Price.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}