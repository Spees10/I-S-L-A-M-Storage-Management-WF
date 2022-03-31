
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SAVE1 = new I_S_L_A_M.GradientButton();
            this.SAVE2 = new I_S_L_A_M.GradientButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 12F);
            this.label1.Location = new System.Drawing.Point(42, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(369, 44);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(219, 26);
            this.CategoryComboBox.TabIndex = 1;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 232);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 24);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 282);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 24);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 12F);
            this.label2.Location = new System.Drawing.Point(42, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Code";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(204, 331);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 24);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 12F);
            this.label3.Location = new System.Drawing.Point(412, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Production Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ravie", 12F);
            this.label4.Location = new System.Drawing.Point(412, 331);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Expired Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ravie", 12F);
            this.label5.Location = new System.Drawing.Point(42, 336);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // New
            // 
            this.New.AutoSize = true;
            this.New.Checked = true;
            this.New.Font = new System.Drawing.Font("Ravie", 12F);
            this.New.Location = new System.Drawing.Point(151, 112);
            this.New.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(71, 26);
            this.New.TabIndex = 13;
            this.New.TabStop = true;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.CheckedChanged += new System.EventHandler(this.New_CheckedChanged);
            // 
            // Exist
            // 
            this.Exist.AutoSize = true;
            this.Exist.Font = new System.Drawing.Font("Ravie", 12F);
            this.Exist.Location = new System.Drawing.Point(276, 112);
            this.Exist.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Exist.Name = "Exist";
            this.Exist.Size = new System.Drawing.Size(88, 26);
            this.Exist.TabIndex = 14;
            this.Exist.Text = "Exist";
            this.Exist.UseVisualStyleBackColor = true;
            this.Exist.CheckedChanged += new System.EventHandler(this.Exist_CheckedChanged);
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(659, 44);
            this.SupplierComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(219, 26);
            this.SupplierComboBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ravie", 12F);
            this.label6.Location = new System.Drawing.Point(379, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Categories";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ravie", 12F);
            this.label7.Location = new System.Drawing.Point(680, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Suppliers";
            // 
            // QuantityNumeric
            // 
            this.QuantityNumeric.Location = new System.Drawing.Point(699, 205);
            this.QuantityNumeric.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.QuantityNumeric.Name = "QuantityNumeric";
            this.QuantityNumeric.Size = new System.Drawing.Size(220, 24);
            this.QuantityNumeric.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ravie", 12F);
            this.label8.Location = new System.Drawing.Point(412, 204);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "Quantity";
            // 
            // BranchComboBox
            // 
            this.BranchComboBox.FormattingEnabled = true;
            this.BranchComboBox.Location = new System.Drawing.Point(88, 44);
            this.BranchComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BranchComboBox.Name = "BranchComboBox";
            this.BranchComboBox.Size = new System.Drawing.Size(219, 26);
            this.BranchComboBox.TabIndex = 20;
            this.BranchComboBox.SelectedIndexChanged += new System.EventHandler(this.BranchComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ravie", 12F);
            this.label9.Location = new System.Drawing.Point(131, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "Branch";
            // 
            // Production
            // 
            this.Production.Location = new System.Drawing.Point(700, 269);
            this.Production.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Production.Name = "Production";
            this.Production.Size = new System.Drawing.Size(363, 24);
            this.Production.TabIndex = 22;
            // 
            // Expired
            // 
            this.Expired.Location = new System.Drawing.Point(699, 331);
            this.Expired.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Expired.Name = "Expired";
            this.Expired.Size = new System.Drawing.Size(363, 24);
            this.Expired.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 384);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1041, 199);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SAVE1
            // 
            this.SAVE1.Angle = 311F;
            this.SAVE1.BackColor = System.Drawing.Color.Transparent;
            this.SAVE1.BorderRadius = 20;
            this.SAVE1.Color0 = System.Drawing.Color.DodgerBlue;
            this.SAVE1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.SAVE1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVE1.ForeColor = System.Drawing.Color.Black;
            this.SAVE1.Location = new System.Drawing.Point(462, 589);
            this.SAVE1.Name = "SAVE1";
            this.SAVE1.Size = new System.Drawing.Size(126, 55);
            this.SAVE1.TabIndex = 46;
            this.SAVE1.Texty = "SAVE";
            this.SAVE1.Click += new System.EventHandler(this.Save1);
            // 
            // SAVE2
            // 
            this.SAVE2.Angle = 293F;
            this.SAVE2.BorderRadius = 20;
            this.SAVE2.Color0 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.SAVE2.Color1 = System.Drawing.Color.Crimson;
            this.SAVE2.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold);
            this.SAVE2.ForeColor = System.Drawing.Color.Black;
            this.SAVE2.Location = new System.Drawing.Point(462, 589);
            this.SAVE2.Name = "SAVE2";
            this.SAVE2.Size = new System.Drawing.Size(126, 55);
            this.SAVE2.TabIndex = 45;
            this.SAVE2.Texty = "SAVE";
            this.SAVE2.Click += new System.EventHandler(this.Save2);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Ravie", 12F);
            this.radioButton1.Location = new System.Drawing.Point(670, 95);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(244, 26);
            this.radioButton1.TabIndex = 47;
            this.radioButton1.Text = "New Another Branch";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(699, 143);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 26);
            this.comboBox1.TabIndex = 48;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ravie", 12F);
            this.label10.Location = new System.Drawing.Point(42, 187);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 22);
            this.label10.TabIndex = 50;
            this.label10.Text = "ID";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(204, 182);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 24);
            this.textBox4.TabIndex = 49;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 661);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.SAVE2);
            this.Controls.Add(this.SAVE1);
            this.Controls.Add(this.dataGridView1);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private GradientButton SAVE1;
        private GradientButton SAVE2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
    }
}