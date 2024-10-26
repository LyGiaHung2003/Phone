namespace PhoneWarehouse.Views
{
    partial class NhanVien
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
            txtAddress = new TextBox();
            groupBox1 = new GroupBox();
            button5 = new Button();
            textBox6 = new TextBox();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtPhoneNumber = new TextBox();
            txtFirstName = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            id_customer = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            name_user = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 15F);
            txtAddress.Location = new Point(617, 107);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(400, 41);
            txtAddress.TabIndex = 35;
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
            groupBox1.Location = new Point(-4, 883);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1910, 134);
            groupBox1.TabIndex = 33;
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
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 15F);
            txtPhoneNumber.Location = new Point(1191, 38);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(132, 41);
            txtPhoneNumber.TabIndex = 30;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 15F);
            txtFirstName.Location = new Point(277, 37);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(210, 41);
            txtFirstName.TabIndex = 28;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(493, 40);
            label2.Name = "label2";
            label2.Size = new Size(118, 45);
            label2.TabIndex = 26;
            label2.Text = "Mật khẩu";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_customer, ID, Name, Quantity, name_user, phone, address, Amount, role });
            dataGridView1.Location = new Point(-4, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1910, 709);
            dataGridView1.TabIndex = 31;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(147, 37);
            label1.Name = "label1";
            label1.Size = new Size(136, 45);
            label1.TabIndex = 25;
            label1.Text = "Tài khoản";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(506, 109);
            label4.Name = "label4";
            label4.Size = new Size(105, 36);
            label4.TabIndex = 34;
            label4.Text = "Địa chỉ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 15F);
            txtLastName.Location = new Point(617, 39);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(239, 41);
            txtLastName.TabIndex = 29;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(1033, 41);
            label3.Name = "label3";
            label3.Size = new Size(165, 41);
            label3.TabIndex = 27;
            label3.Text = "Họ nhân viên";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(1348, 105);
            label8.Name = "label8";
            label8.Size = new Size(160, 45);
            label8.TabIndex = 37;
            label8.Text = "Phân quyền";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(117, 109);
            label9.Name = "label9";
            label9.Size = new Size(166, 45);
            label9.TabIndex = 36;
            label9.Text = "Số điện thoại";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(1070, 104);
            label10.Name = "label10";
            label10.Size = new Size(128, 41);
            label10.TabIndex = 38;
            label10.Text = "Giới tính";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(1329, 42);
            label5.Name = "label5";
            label5.Size = new Size(179, 36);
            label5.TabIndex = 32;
            label5.Text = "Tên nhân viên";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(1514, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 41);
            textBox1.TabIndex = 39;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(277, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 41);
            textBox2.TabIndex = 40;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox1.Location = new Point(1191, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 43);
            comboBox1.TabIndex = 41;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 15F);
            radioButton1.Location = new Point(1514, 84);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(109, 39);
            radioButton1.TabIndex = 42;
            radioButton1.TabStop = true;
            radioButton1.Text = "Admin";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 15F);
            radioButton2.Location = new Point(1514, 129);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(86, 39);
            radioButton2.TabIndex = 43;
            radioButton2.TabStop = true;
            radioButton2.Text = "User";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // id_customer
            // 
            id_customer.HeaderText = "ID";
            id_customer.MinimumWidth = 6;
            id_customer.Name = "id_customer";
            // 
            // ID
            // 
            ID.HeaderText = "Tài khoản";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // Name
            // 
            Name.HeaderText = "Mật khẩu";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Họ nhân viên";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // name_user
            // 
            name_user.HeaderText = "Tên nhân viên";
            name_user.MinimumWidth = 6;
            name_user.Name = "name_user";
            // 
            // phone
            // 
            phone.HeaderText = "Số điện thoại";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            // 
            // address
            // 
            address.HeaderText = "Địa chhỉ";
            address.MinimumWidth = 6;
            address.Name = "address";
            // 
            // Amount
            // 
            Amount.HeaderText = "Giới tính";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            // 
            // role
            // 
            role.HeaderText = "Phân quyền";
            role.MinimumWidth = 6;
            role.Name = "role";
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtFirstName);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label8);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhanVien";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAddress;
        private GroupBox groupBox1;
        private Button button5;
        private TextBox textBox6;
        private Label label6;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtPhoneNumber;
        private TextBox txtFirstName;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DataGridViewTextBoxColumn id_customer;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn name_user;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn role;
    }
}