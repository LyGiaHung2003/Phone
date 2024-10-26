namespace PhoneWarehouse.Views
{
    partial class Phieuxuat
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
            txtTotal = new TextBox();
            txtUnitPrice = new TextBox();
            txtEmployeeId = new TextBox();
            txtQuantity = new TextBox();
            txtProductId = new TextBox();
            label9 = new Label();
            dateExportDate = new DateTimePicker();
            label8 = new Label();
            txtExportId = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            id_export = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            nameuser = new DataGridViewTextBoxColumn();
            Day = new DataGridViewTextBoxColumn();
            nameProduct = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label6 = new Label();
            button5 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 15F);
            txtTotal.Location = new Point(1438, 100);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(246, 41);
            txtTotal.TabIndex = 55;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Segoe UI", 15F);
            txtUnitPrice.Location = new Point(1066, 97);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(246, 41);
            txtUnitPrice.TabIndex = 54;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Font = new Font("Segoe UI", 15F);
            txtEmployeeId.Location = new Point(230, 102);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(241, 41);
            txtEmployeeId.TabIndex = 53;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 15F);
            txtQuantity.Location = new Point(685, 100);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(212, 41);
            txtQuantity.TabIndex = 51;
            // 
            // txtProductId
            // 
            txtProductId.Font = new Font("Segoe UI", 15F);
            txtProductId.Location = new Point(685, 22);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(212, 41);
            txtProductId.TabIndex = 50;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(510, 22);
            label9.Name = "label9";
            label9.Size = new Size(180, 38);
            label9.TabIndex = 49;
            label9.Text = "Tên sản phẩm";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateExportDate
            // 
            dateExportDate.Font = new Font("Segoe UI", 15F);
            dateExportDate.Format = DateTimePickerFormat.Short;
            dateExportDate.Location = new Point(1066, 20);
            dateExportDate.Name = "dateExportDate";
            dateExportDate.Size = new Size(170, 41);
            dateExportDate.TabIndex = 48;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(1330, 97);
            label8.Name = "label8";
            label8.Size = new Size(113, 42);
            label8.TabIndex = 47;
            label8.Text = "Tổng giá";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtExportId
            // 
            txtExportId.Font = new Font("Segoe UI", 15F);
            txtExportId.Location = new Point(230, 20);
            txtExportId.Name = "txtExportId";
            txtExportId.Size = new Size(241, 41);
            txtExportId.TabIndex = 41;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(121, 12);
            label1.Name = "label1";
            label1.Size = new Size(114, 57);
            label1.TabIndex = 38;
            label1.Text = "Số phiếu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_export, ID, nameuser, Day, nameProduct, Quantity, Amount, Name });
            dataGridView1.Location = new Point(-4, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1910, 725);
            dataGridView1.TabIndex = 42;
            // 
            // id_export
            // 
            id_export.HeaderText = "ID";
            id_export.MinimumWidth = 6;
            id_export.Name = "id_export";
            // 
            // ID
            // 
            ID.HeaderText = "Số phiếu";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // nameuser
            // 
            nameuser.HeaderText = "Người bán";
            nameuser.MinimumWidth = 6;
            nameuser.Name = "nameuser";
            // 
            // Day
            // 
            Day.HeaderText = "Ngày bán";
            Day.MinimumWidth = 6;
            Day.Name = "Day";
            // 
            // nameProduct
            // 
            nameProduct.HeaderText = "Tên sản phẩm";
            nameProduct.MinimumWidth = 6;
            nameProduct.Name = "nameProduct";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Số lượng";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // Amount
            // 
            Amount.HeaderText = "Đơn giá";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            // 
            // Name
            // 
            Name.HeaderText = "Tổng giá";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(78, 95);
            label3.Name = "label3";
            label3.Size = new Size(148, 57);
            label3.TabIndex = 40;
            label3.Text = "Người bán";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(954, 97);
            label6.Name = "label6";
            label6.Size = new Size(108, 44);
            label6.TabIndex = 45;
            label6.Text = "Đơn giá";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            button5.Location = new Point(1719, 62);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 25;
            button5.Text = "Tìm";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1569, 62);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(144, 27);
            textBox4.TabIndex = 21;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(1455, 42);
            label4.Name = "label4";
            label4.Size = new Size(123, 57);
            label4.TabIndex = 20;
            label4.Text = "Tìm kiếm";
            label4.TextAlign = ContentAlignment.MiddleCenter;
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
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(575, 103);
            label5.Name = "label5";
            label5.Size = new Size(115, 38);
            label5.TabIndex = 43;
            label5.Text = "Số lượng";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(-4, 887);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1910, 136);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
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
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(932, 18);
            label7.Name = "label7";
            label7.Size = new Size(139, 43);
            label7.TabIndex = 46;
            label7.Text = "Ngày bán";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Phieuxuat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(txtTotal);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtEmployeeId);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductId);
            Controls.Add(dateExportDate);
            Controls.Add(label8);
            Controls.Add(txtExportId);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label9);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockOut";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTotal;
        private TextBox txtUnitPrice;
        private TextBox txtEmployeeId;
        private TextBox txtQuantity;
        private TextBox txtProductId;
        private Label label9;
        private DateTimePicker dateExportDate;
        private Label label8;
        private TextBox txtExportId;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label6;
        private Button button5;
        private TextBox textBox4;
        private Label label4;
        private Button button2;
        private Label label5;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button1;
        private Label label7;
        private DataGridViewTextBoxColumn id_export;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nameuser;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn nameProduct;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Name;
    }
}