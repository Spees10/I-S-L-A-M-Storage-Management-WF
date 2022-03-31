
namespace I_S_L_A_M
{
    partial class ProductForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Save1 = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.RadioButton();
            this.Exist = new System.Windows.Forms.RadioButton();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.QuantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.BranchComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Production = new System.Windows.Forms.DateTimePicker();
            this.Expired = new System.Windows.Forms.DateTimePicker();
            this.Save2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(504, 39);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(219, 28);
            this.CategoryComboBox.TabIndex = 1;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 200);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 25);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(270, 261);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 25);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Code";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(270, 311);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 25);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Production Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 329);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Expired Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // Save1
            // 
            this.Save1.Location = new System.Drawing.Point(587, 612);
            this.Save1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Save1.Name = "Save1";
            this.Save1.Size = new System.Drawing.Size(104, 30);
            this.Save1.TabIndex = 12;
            this.Save1.Text = "SAVE";
            this.Save1.UseVisualStyleBackColor = true;
            this.Save1.Click += new System.EventHandler(this.button1_Click);
            // 
            // New
            // 
            this.New.AutoSize = true;
            this.New.Checked = true;
            this.New.Font = new System.Drawing.Font("MonoLisa-Regular", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(493, 119);
            this.New.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(72, 32);
            this.New.TabIndex = 13;
            this.New.TabStop = true;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            // 
            // Exist
            // 
            this.Exist.AutoSize = true;
            this.Exist.Font = new System.Drawing.Font("MonoLisa-Regular", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exist.Location = new System.Drawing.Point(591, 119);
            this.Exist.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Exist.Name = "Exist";
            this.Exist.Size = new System.Drawing.Size(100, 32);
            this.Exist.TabIndex = 14;
            this.Exist.Text = "Exist";
            this.Exist.UseVisualStyleBackColor = true;
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(794, 39);
            this.SupplierComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(219, 28);
            this.SupplierComboBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Categories";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(847, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Suppliers";
            // 
            // QuantityNumeric
            // 
            this.QuantityNumeric.Location = new System.Drawing.Point(770, 201);
            this.QuantityNumeric.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.QuantityNumeric.Name = "QuantityNumeric";
            this.QuantityNumeric.Size = new System.Drawing.Size(220, 25);
            this.QuantityNumeric.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(576, 200);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Quantity";
            // 
            // BranchComboBox
            // 
            this.BranchComboBox.FormattingEnabled = true;
            this.BranchComboBox.Location = new System.Drawing.Point(223, 39);
            this.BranchComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BranchComboBox.Name = "BranchComboBox";
            this.BranchComboBox.Size = new System.Drawing.Size(219, 28);
            this.BranchComboBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Branch";
            // 
            // Production
            // 
            this.Production.Location = new System.Drawing.Point(770, 266);
            this.Production.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Production.Name = "Production";
            this.Production.Size = new System.Drawing.Size(363, 25);
            this.Production.TabIndex = 22;
            // 
            // Expired
            // 
            this.Expired.Location = new System.Drawing.Point(770, 324);
            this.Expired.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Expired.Name = "Expired";
            this.Expired.Size = new System.Drawing.Size(363, 25);
            this.Expired.TabIndex = 23;
            // 
            // Save2
            // 
            this.Save2.Location = new System.Drawing.Point(587, 612);
            this.Save2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Save2.Name = "Save2";
            this.Save2.Size = new System.Drawing.Size(104, 30);
            this.Save2.TabIndex = 24;
            this.Save2.Text = "SAVE";
            this.Save2.UseVisualStyleBackColor = true;
            this.Save2.Click += new System.EventHandler(this.Save2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 384);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1198, 199);
            this.dataGridView1.TabIndex = 25;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 665);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Save2);
            this.Controls.Add(this.Expired);
            this.Controls.Add(this.Production);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BranchComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.QuantityNumeric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SupplierComboBox);
            this.Controls.Add(this.Exist);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Save1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MonoLisa-Regular", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Save1;
        private System.Windows.Forms.RadioButton New;
        private System.Windows.Forms.RadioButton Exist;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown QuantityNumeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox BranchComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Production;
        private System.Windows.Forms.DateTimePicker Expired;
        private System.Windows.Forms.Button Save2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}