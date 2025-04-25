namespace SWE5201BankingSystemHE20882
{
    partial class AddCustomerForm
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
            txtFirstName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            label6 = new Label();
            txtCardNumber = new TextBox();
            label7 = new Label();
            txtPin = new TextBox();
            label8 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label9 = new Label();
            cmbStatus = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 97);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(170, 91);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(297, 31);
            txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 164);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 2;
            label2.Text = "Last Name:";
            label2.Click += label2_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(170, 158);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(297, 31);
            txtLastName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 228);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            label3.Click += label3_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(170, 222);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(297, 31);
            txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 298);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 6;
            label4.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(170, 292);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(297, 31);
            txtAddress.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 366);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 8;
            label5.Text = "Phone Number:";
            label5.Click += label5_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(201, 360);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(266, 31);
            txtPhone.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 434);
            label6.Name = "label6";
            label6.Size = new Size(123, 25);
            label6.TabIndex = 10;
            label6.Text = "Card Number:";
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(201, 428);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(266, 31);
            txtCardNumber.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 507);
            label7.Name = "label7";
            label7.Size = new Size(44, 25);
            label7.TabIndex = 12;
            label7.Text = "PIN:";
            // 
            // txtPin
            // 
            txtPin.Location = new Point(112, 507);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(355, 31);
            txtPin.TabIndex = 13;
            txtPin.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 578);
            label8.Name = "label8";
            label8.Size = new Size(64, 25);
            label8.TabIndex = 14;
            label8.Text = "Status:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(47, 633);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(194, 52);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(247, 633);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(220, 52);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label9.Location = new Point(126, 31);
            label9.Name = "label9";
            label9.Size = new Size(277, 32);
            label9.TabIndex = 18;
            label9.Text = "ADD CUSTOMER FORM";
            label9.Click += label9_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Not-Active" });
            cmbStatus.Location = new Point(117, 575);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(350, 33);
            cmbStatus.TabIndex = 19;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 716);
            Controls.Add(cmbStatus);
            Controls.Add(label9);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label8);
            Controls.Add(txtPin);
            Controls.Add(label7);
            Controls.Add(txtCardNumber);
            Controls.Add(label6);
            Controls.Add(txtPhone);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Name = "AddCustomerForm";
            Text = "AddCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtCardNumber;
        private Label label7;
        private TextBox txtPin;
        private Label label8;
        private Button btnSave;
        private Button btnCancel;
        private Label label9;
        private ComboBox cmbStatus;
    }
}