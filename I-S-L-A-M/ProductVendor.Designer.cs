
namespace I_S_L_A_M
{
    partial class ProductVendor
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.BranchComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.QuantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VendorComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceLB = new System.Windows.Forms.TextBox();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SellProduct = new I_S_L_A_M.GradientButton();
            this.PaidUp = new System.Windows.Forms.TextBox();
            this.PaidUpTB = new System.Windows.Forms.Label();
            this.Stars = new System.Windows.Forms.Label();
            this.RestPaidLB = new System.Windows.Forms.Label();
            this.TotalLB = new System.Windows.Forms.Label();
            this.SellProduct2 = new I_S_L_A_M.GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ravie", 12F);
            this.label9.Location = new System.Drawing.Point(206, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 22);
            this.label9.TabIndex = 57;
            this.label9.Text = "Branch";
            // 
            // BranchComboBox
            // 
            this.BranchComboBox.FormattingEnabled = true;
            this.BranchComboBox.Location = new System.Drawing.Point(244, 73);
            this.BranchComboBox.Name = "BranchComboBox";
            this.BranchComboBox.Size = new System.Drawing.Size(121, 21);
            this.BranchComboBox.TabIndex = 56;
            this.BranchComboBox.SelectedIndexChanged += new System.EventHandler(this.BranchComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ravie", 12F);
            this.label8.Location = new System.Drawing.Point(611, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 22);
            this.label8.TabIndex = 55;
            this.label8.Text = "Quantity";
            // 
            // QuantityNumeric
            // 
            this.QuantityNumeric.Location = new System.Drawing.Point(741, 159);
            this.QuantityNumeric.Name = "QuantityNumeric";
            this.QuantityNumeric.Size = new System.Drawing.Size(125, 20);
            this.QuantityNumeric.TabIndex = 54;
            this.QuantityNumeric.ValueChanged += new System.EventHandler(this.QuantityNumeric_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ravie", 12F);
            this.label7.Location = new System.Drawing.Point(570, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 22);
            this.label7.TabIndex = 53;
            this.label7.Text = "Vendor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ravie", 12F);
            this.label6.Location = new System.Drawing.Point(401, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 52;
            this.label6.Text = "Categories";
            // 
            // VendorComboBox
            // 
            this.VendorComboBox.FormattingEnabled = true;
            this.VendorComboBox.Location = new System.Drawing.Point(589, 73);
            this.VendorComboBox.Name = "VendorComboBox";
            this.VendorComboBox.Size = new System.Drawing.Size(121, 21);
            this.VendorComboBox.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ravie", 12F);
            this.label5.Location = new System.Drawing.Point(393, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 50;
            this.label5.Text = "Price";
            // 
            // PriceLB
            // 
            this.PriceLB.Location = new System.Drawing.Point(466, 153);
            this.PriceLB.Name = "PriceLB";
            this.PriceLB.ReadOnly = true;
            this.PriceLB.Size = new System.Drawing.Size(100, 20);
            this.PriceLB.TabIndex = 49;
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(265, 153);
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            this.Name1.Size = new System.Drawing.Size(100, 20);
            this.Name1.TabIndex = 48;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(983, 297);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(426, 73);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 46;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 12F);
            this.label1.Location = new System.Drawing.Point(183, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 45;
            this.label1.Text = "Name";
            // 
            // SellProduct
            // 
            this.SellProduct.Angle = 64F;
            this.SellProduct.BorderRadius = 20;
            this.SellProduct.Color0 = System.Drawing.Color.DodgerBlue;
            this.SellProduct.Color1 = System.Drawing.Color.PaleGreen;
            this.SellProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellProduct.ForeColor = System.Drawing.Color.Black;
            this.SellProduct.Location = new System.Drawing.Point(413, 598);
            this.SellProduct.Name = "SellProduct";
            this.SellProduct.Size = new System.Drawing.Size(174, 51);
            this.SellProduct.TabIndex = 58;
            this.SellProduct.Texty = "Sell";
            this.SellProduct.Click += new System.EventHandler(this.SellProduct_Click);
            // 
            // PaidUp
            // 
            this.PaidUp.Location = new System.Drawing.Point(265, 234);
            this.PaidUp.Name = "PaidUp";
            this.PaidUp.Size = new System.Drawing.Size(100, 20);
            this.PaidUp.TabIndex = 61;
            // 
            // PaidUpTB
            // 
            this.PaidUpTB.AutoSize = true;
            this.PaidUpTB.Font = new System.Drawing.Font("Ravie", 12F);
            this.PaidUpTB.Location = new System.Drawing.Point(171, 229);
            this.PaidUpTB.Name = "PaidUpTB";
            this.PaidUpTB.Size = new System.Drawing.Size(88, 22);
            this.PaidUpTB.TabIndex = 62;
            this.PaidUpTB.Text = "Paid Up";
            // 
            // Stars
            // 
            this.Stars.AutoSize = true;
            this.Stars.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stars.Location = new System.Drawing.Point(718, 229);
            this.Stars.Name = "Stars";
            this.Stars.Size = new System.Drawing.Size(0, 24);
            this.Stars.TabIndex = 63;
            // 
            // RestPaidLB
            // 
            this.RestPaidLB.AutoSize = true;
            this.RestPaidLB.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestPaidLB.Location = new System.Drawing.Point(437, 230);
            this.RestPaidLB.Name = "RestPaidLB";
            this.RestPaidLB.Size = new System.Drawing.Size(0, 24);
            this.RestPaidLB.TabIndex = 64;
            // 
            // TotalLB
            // 
            this.TotalLB.AutoSize = true;
            this.TotalLB.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLB.Location = new System.Drawing.Point(273, 193);
            this.TotalLB.Name = "TotalLB";
            this.TotalLB.Size = new System.Drawing.Size(0, 24);
            this.TotalLB.TabIndex = 65;
            // 
            // SellProduct2
            // 
            this.SellProduct2.Angle = 144F;
            this.SellProduct2.BorderRadius = 20;
            this.SellProduct2.Color0 = System.Drawing.Color.MediumSpringGreen;
            this.SellProduct2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.SellProduct2.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold);
            this.SellProduct2.ForeColor = System.Drawing.Color.Wheat;
            this.SellProduct2.Location = new System.Drawing.Point(413, 598);
            this.SellProduct2.Name = "SellProduct2";
            this.SellProduct2.Size = new System.Drawing.Size(174, 51);
            this.SellProduct2.TabIndex = 66;
            this.SellProduct2.Texty = "Sell";
            this.SellProduct2.Click += new System.EventHandler(this.SellProduct2_Click);
            // 
            // ProductVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 661);
            this.Controls.Add(this.SellProduct2);
            this.Controls.Add(this.TotalLB);
            this.Controls.Add(this.RestPaidLB);
            this.Controls.Add(this.Stars);
            this.Controls.Add(this.PaidUpTB);
            this.Controls.Add(this.PaidUp);
            this.Controls.Add(this.SellProduct);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BranchComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.QuantityNumeric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VendorComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PriceLB);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ProductVendor";
            this.Text = "ProductVendor";
            this.Load += new System.EventHandler(this.ProductVendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GradientButton SellProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox BranchComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown QuantityNumeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox VendorComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PriceLB;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PaidUp;
        private System.Windows.Forms.Label PaidUpTB;
        private System.Windows.Forms.Label Stars;
        private System.Windows.Forms.Label RestPaidLB;
        private System.Windows.Forms.Label TotalLB;
        private GradientButton SellProduct2;
    }
}