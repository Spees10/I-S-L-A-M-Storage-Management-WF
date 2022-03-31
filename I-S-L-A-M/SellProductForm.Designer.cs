
namespace I_S_L_A_M
{
    partial class SellProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.QuantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.BranchComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SellProduct = new I_S_L_A_M.GradientButton();
            this.SellProduct2 = new I_S_L_A_M.GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 12F);
            this.label1.Location = new System.Drawing.Point(205, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(447, 77);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 25;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 297);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(286, 157);
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            this.Name1.Size = new System.Drawing.Size(100, 20);
            this.Name1.TabIndex = 27;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(487, 157);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ravie", 12F);
            this.label5.Location = new System.Drawing.Point(410, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Price";
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(610, 77);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(121, 21);
            this.CustomerComboBox.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ravie", 12F);
            this.label6.Location = new System.Drawing.Point(419, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 38;
            this.label6.Text = "Categories";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ravie", 12F);
            this.label7.Location = new System.Drawing.Point(585, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 22);
            this.label7.TabIndex = 39;
            this.label7.Text = "Customer";
            // 
            // QuantityNumeric
            // 
            this.QuantityNumeric.Location = new System.Drawing.Point(762, 163);
            this.QuantityNumeric.Name = "QuantityNumeric";
            this.QuantityNumeric.Size = new System.Drawing.Size(125, 20);
            this.QuantityNumeric.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ravie", 12F);
            this.label8.Location = new System.Drawing.Point(634, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 22);
            this.label8.TabIndex = 41;
            this.label8.Text = "Quantity";
            // 
            // BranchComboBox
            // 
            this.BranchComboBox.FormattingEnabled = true;
            this.BranchComboBox.Location = new System.Drawing.Point(265, 77);
            this.BranchComboBox.Name = "BranchComboBox";
            this.BranchComboBox.Size = new System.Drawing.Size(121, 21);
            this.BranchComboBox.TabIndex = 42;
            this.BranchComboBox.SelectedIndexChanged += new System.EventHandler(this.BranchComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ravie", 12F);
            this.label9.Location = new System.Drawing.Point(230, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 22);
            this.label9.TabIndex = 43;
            this.label9.Text = "Branch";
            // 
            // SellProduct
            // 
            this.SellProduct.Angle = 293F;
            this.SellProduct.BorderRadius = 20;
            this.SellProduct.Color0 = System.Drawing.Color.DodgerBlue;
            this.SellProduct.Color1 = System.Drawing.Color.PaleGreen;
            this.SellProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellProduct.ForeColor = System.Drawing.Color.Black;
            this.SellProduct.Location = new System.Drawing.Point(434, 238);
            this.SellProduct.Name = "SellProduct";
            this.SellProduct.Size = new System.Drawing.Size(174, 51);
            this.SellProduct.TabIndex = 44;
            this.SellProduct.Texty = "Sell";
            this.SellProduct.Click += new System.EventHandler(this.SellProd);
            // 
            // SellProduct2
            // 
            this.SellProduct2.Angle = 286F;
            this.SellProduct2.BorderRadius = 20;
            this.SellProduct2.Color0 = System.Drawing.Color.CadetBlue;
            this.SellProduct2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.SellProduct2.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold);
            this.SellProduct2.ForeColor = System.Drawing.Color.White;
            this.SellProduct2.Location = new System.Drawing.Point(434, 238);
            this.SellProduct2.Name = "SellProduct2";
            this.SellProduct2.Size = new System.Drawing.Size(174, 51);
            this.SellProduct2.TabIndex = 45;
            this.SellProduct2.Texty = "Sell";
            this.SellProduct2.Click += new System.EventHandler(this.SellProduct2_Click);
            // 
            // SellProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 661);
            this.Controls.Add(this.SellProduct2);
            this.Controls.Add(this.SellProduct);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BranchComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.QuantityNumeric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.label1);
            this.Name = "SellProductForm";
            this.Text = "SellProductForm";
            this.Load += new System.EventHandler(this.SellProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private new System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown QuantityNumeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox BranchComboBox;
        private System.Windows.Forms.Label label9;
        private GradientButton SellProduct;
        private GradientButton SellProduct2;
    }
}