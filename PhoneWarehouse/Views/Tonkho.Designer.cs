namespace PhoneWarehouse.Views
{
    partial class kho
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProductCode = new TextBox();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            dataGridView1 = new DataGridView();
            txtLastPrice = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            button5 = new Button();
            textBox6 = new TextBox();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtTotal = new TextBox();
            label4 = new Label();
            txtStandardCost = new TextBox();
            label7 = new Label();
            id_product = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            prive = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Tong = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 57);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phầm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(325, 9);
            label2.Name = "label2";
            label2.Size = new Size(169, 57);
            label2.TabIndex = 1;
            label2.Text = "Tên sản phẩm";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(1329, 9);
            label3.Name = "label3";
            label3.Size = new Size(119, 57);
            label3.TabIndex = 2;
            label3.Text = "Số lượng";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtProductCode
            // 
            txtProductCode.Font = new Font("Segoe UI", 15F);
            txtProductCode.Location = new Point(172, 17);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(124, 41);
            txtProductCode.TabIndex = 4;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 15F);
            txtProductName.Location = new Point(491, 17);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(187, 41);
            txtProductName.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 15F);
            txtQuantity.Location = new Point(1440, 17);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(97, 41);
            txtQuantity.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_product, ID, Name, Amount, prive, Quantity, Tong });
            dataGridView1.Location = new Point(0, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1904, 838);
            dataGridView1.TabIndex = 8;
            // 
            // txtLastPrice
            // 
            txtLastPrice.Font = new Font("Segoe UI", 15F);
            txtLastPrice.Location = new Point(1114, 17);
            txtLastPrice.Name = "txtLastPrice";
            txtLastPrice.Size = new Size(187, 41);
            txtLastPrice.TabIndex = 10;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(998, 9);
            label5.Name = "label5";
            label5.Size = new Size(122, 57);
            label5.TabIndex = 9;
            label5.Text = "Giá nhập";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(0, 903);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1910, 134);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(1708, 61);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 24;
            button5.Text = "Tìm";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1558, 62);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(144, 27);
            textBox6.TabIndex = 23;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(1440, 42);
            label6.Name = "label6";
            label6.Size = new Size(123, 57);
            label6.TabIndex = 22;
            label6.Text = "Tìm kiếm";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F);
            button4.Location = new Point(1160, 35);
            button4.Name = "button4";
            button4.Size = new Size(154, 65);
            button4.TabIndex = 15;
            button4.Text = "Clear All";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F);
            button3.Location = new Point(964, 35);
            button3.Name = "button3";
            button3.Size = new Size(154, 65);
            button3.TabIndex = 14;
            button3.Text = "Xoá";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(758, 35);
            button2.Name = "button2";
            button2.Size = new Size(154, 65);
            button2.TabIndex = 13;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(551, 35);
            button1.Name = "button1";
            button1.Size = new Size(154, 65);
            button1.TabIndex = 12;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 15F);
            txtTotal.Location = new Point(1674, 17);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(216, 41);
            txtTotal.TabIndex = 13;
            txtTotal.TextChanged += textBox4_TextChanged_1;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(1558, 9);
            label4.Name = "label4";
            label4.Size = new Size(123, 57);
            label4.TabIndex = 12;
            label4.Text = "Tổng giá";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtStandardCost
            // 
            txtStandardCost.Font = new Font("Segoe UI", 15F);
            txtStandardCost.Location = new Point(796, 17);
            txtStandardCost.Name = "txtStandardCost";
            txtStandardCost.Size = new Size(196, 41);
            txtStandardCost.TabIndex = 15;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(695, 9);
            label7.Name = "label7";
            label7.Size = new Size(110, 57);
            label7.TabIndex = 14;
            label7.Text = "Giá bán";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // id_product
            // 
            id_product.HeaderText = "ID";
            id_product.MinimumWidth = 6;
            id_product.Name = "id_product";
            // 
            // ID
            // 
            ID.HeaderText = "Mã sản phẩm";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // Name
            // 
            Name.HeaderText = "Tên sản phẩm";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            // 
            // Amount
            // 
            Amount.HeaderText = "Giá bán";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            // 
            // prive
            // 
            prive.HeaderText = "Giá nhập";
            prive.MinimumWidth = 6;
            prive.Name = "prive";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Số lượng";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // Tong
            // 
            Tong.HeaderText = "Tổng giá";
            Tong.MinimumWidth = 6;
            Tong.Name = "Tong";
            // 
            // kho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(txtStandardCost);
            Controls.Add(label7);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(txtLastPrice);
            Controls.Add(dataGridView1);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Controls.Add(txtProductCode);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kho";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProductCode;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private DataGridView dataGridView1;
        private TextBox txtLastPrice;
        private Label label5;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox6;
        private Label label6;
        private Button button5;
        private TextBox txtTotal;
        private Label label4;
        private TextBox txtStandardCost;
        private Label label7;
        private DataGridViewTextBoxColumn id_product;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn prive;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Tong;
    }
}