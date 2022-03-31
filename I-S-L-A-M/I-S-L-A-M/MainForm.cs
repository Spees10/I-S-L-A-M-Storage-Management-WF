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
        //private Button gradientButton;
        private GradientButton gradientButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Main()
        {
            InitializeComponent();
            random = new Random();

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel2.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (gradientButton != (GradientButton)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    gradientButton = (GradientButton)btnSender;
                    gradientButton.BackColor = color;
                    gradientButton.ForeColor = Color.White;
                    gradientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panel3.BackColor = color;
                    //panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(childForm);
            this.panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }

        private void gradientButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateBranch(), sender);
        }

        private void gradientButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CategoryForm(), sender);
        }

        private void gradientButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateSupplier(), sender);
        }


        private void gradientButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductForm(), sender);
        }
        private void gradientButton6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateCustomer(), sender);
        }

        private void gradientButton7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportsForm(), sender);
        }

        private void gradientButton8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SellProductForm(), sender);

        }
        private void gradientButton9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerBILLForm(), sender);

        }

        private void gradientButton10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SupplierBillForm(), sender);
        }

        private void gradientButton11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}