namespace PhoneWarehouse.Views
{
    partial class KhachHang
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
            button5 = new Button();
            textBox6 = new TextBox();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            label5 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            txtPhoneNumber = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            id_customer = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            txtAddress = new TextBox();
            label4 = new Label();
            comboBoxGender = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F);
            button3.Location = new Point(964, 35);
            button3.Name = "button3";
            button3.Size = new Size(154, 65);
            button3.TabIndex = 14;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(551, 35);
            button1.Name = "button1";
            button1.Size = new Size(154, 65);
            button1.TabIndex = 12;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(1180, 38);
            label5.Name = "label5";
            label5.Size = new Size(130, 36);
            label5.TabIndex = 19;
            label5.Text = "Giới tính";
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
            groupBox1.Location = new Point(-4, 896);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1910, 134);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(758, 35);
            button2.Name = "button2";
            button2.Size = new Size(154, 65);
            button2.TabIndex = 13;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 15F);
            txtPhoneNumber.Location = new Point(1002, 36);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(163, 41);
            txtPhoneNumber.TabIndex = 17;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 15F);
            txtLastName.Location = new Point(585, 34);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(239, 41);
            txtLastName.TabIndex = 16;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 15F);
            txtFirstName.Location = new Point(256, 34);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(135, 41);
            txtFirstName.TabIndex = 15;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(842, 34);
            label3.Name = "label3";
            label3.Size = new Size(165, 41);
            label3.TabIndex = 14;
            label3.Text = "Số điện thoại";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(397, 32);
            label2.Name = "label2";
            label2.Size = new Size(199, 45);
            label2.TabIndex = 13;
            label2.Text = "Tên khách hàng";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(51, 29);
            label1.Name = "label1";
            label1.Size = new Size(199, 45);
            label1.TabIndex = 12;
            label1.Text = "Họ khách hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_customer, ID, Name, Quantity, Amount, address });
            dataGridView1.Location = new Point(-4, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1910, 801);
            dataGridView1.TabIndex = 18;
            // 
            // id_customer
            // 
            id_customer.HeaderText = "ID";
            id_customer.MinimumWidth = 6;
            id_customer.Name = "id_customer";
            // 
            // ID
            // 
            ID.HeaderText = "Họ khách hàng";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // Name
            // 
            Name.HeaderText = "Tên khách hàng";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Số điện thoại";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // Amount
            // 
            Amount.HeaderText = "Giới tính";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            // 
            // address
            // 
            address.HeaderText = "Địa chhỉ";
            address.MinimumWidth = 6;
            address.Name = "address";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 15F);
            txtAddress.Location = new Point(1490, 36);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(400, 41);
            txtAddress.TabIndex = 23;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(1387, 38);
            label4.Name = "label4";
            label4.Size = new Size(105, 36);
            label4.TabIndex = 22;
            label4.Text = "Địa chỉ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxGender
            // 
            comboBoxGender.Font = new Font("Segoe UI", 15F);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBoxGender.Location = new Point(1295, 36);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(74, 43);
            comboBoxGender.TabIndex = 24;
            // 
            // KhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(comboBoxGender);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(label4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private TextBox textBox6;
        private Label label6;
        private Button button4;
        private Button button3;
        private Button button1;
        private Label label5;
        private GroupBox groupBox1;
        private Button button2;
        private TextBox txtPhoneNumber;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id_customer;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn address;
        private TextBox txtAddress;
        private Label label4;
        private ComboBox comboBoxGender;
    }
}