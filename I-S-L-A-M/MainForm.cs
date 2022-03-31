/*
 Vendor ===> بيشتري مني
معناه إن الفلوس بتاعت المتجر هتقل
في كمية فلوس ممكن تتأكل انه هو يدفعها

 */

//~~~~~~~~~~~~~
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_S_L_A_M
{
    public partial class Main : Form
    {
        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case 0x84:
        //            base.WndProc(ref m);
        //            if ((int)m.Result == 0x1)
        //                m.Result = (IntPtr)0x2;
        //            return;
        //    }

        //    base.WndProc(ref m);
        //}
        private bool dragging = false;

        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private Context context;

        public Main()
        {
            InitializeComponent();
            context = new Context();
            ChooseGB();
        }

        private void ChooseGB()
        {
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Main_Load(object sender, EventArgs e)
        {
            var tempQuery = from p in context.Stores
                            select p.ID;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            asmehaEh.Controls.Add(childForm);
            asmehaEh.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            ChildName.Texty = childForm.Text;
        }

        private void CreateBranchClick(object sender, EventArgs e)
        {
            OpenChildForm(new CreateBranch(), sender);
            ChooseGB();
            panel8.Visible = true;
        }

        private void CategoryFormClick(object sender, EventArgs e)
        {
            OpenChildForm(new CategoryForm(), sender);
            ChooseGB();
            panel9.Visible = true;
        }

        private void CreateSupplierClick(object sender, EventArgs e)
        {
            OpenChildForm(new CreateSupplier(), sender);
            ChooseGB();
            panel10.Visible = true;
        }

        private void ProductFormClick(object sender, EventArgs e)
        {
            OpenChildForm(new ProductForm(), sender);
            ChooseGB();
            panel11.Visible = true;
        }

        private void CreateCustomerClick(object sender, EventArgs e)
        {
            OpenChildForm(new CreateCustomer(), sender);
            ChooseGB();
            panel12.Visible = true;
        }

        private void ReportsFormClick(object sender, EventArgs e)
        {
            OpenChildForm(new ReportsForm(), sender);
            ChooseGB();
            panel13.Visible = true;
        }

        private void SellProductFormClick(object sender, EventArgs e)
        {
            OpenChildForm(new SellProductForm(), sender);
            ChooseGB();
            panel14.Visible = true;
        }

        private void CustomerBILLFormClick(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerBILLForm(), sender);
            ChooseGB();
            panel15.Visible = true;
        }

        private void SupplierBillFormClick(object sender, EventArgs e)
        {
            OpenChildForm(new SupplierBillForm(), sender);
            ChooseGB();
            panel16.Visible = true;
        }

        private void VendorBillFormClick(object sender, EventArgs e)
        {
            OpenChildForm(new VendorBillForm(), sender);
            ChooseGB();
            panel17.Visible = true;
        }

        private void CreateVendorClick(object sender, EventArgs e)
        {
            OpenChildForm(new CreateVendor(), sender);
            ChooseGB();
            panel18.Visible = true;
        }

        private void ProductVendorClick(object sender, EventArgs e)
        {
            OpenChildForm(new ProductVendor(), sender);
            ChooseGB();
            panel19.Visible = true;
        }

        private void gradientButton11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChildName_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Main(), sender);
        }

        private void gradientButton20_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Main(), sender);
        }
    }
}