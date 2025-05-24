
namespace SWE5201BankingSystemHE20882
{
    partial class AddCustomerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerForm));
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
            label10 = new Label();
            txtCustomerUsername = new TextBox();
            label11 = new Label();
            txtCustomerPassword = new TextBox();
            groupBox1 = new GroupBox();
            label12 = new Label();
            groupBox2 = new GroupBox();
            label13 = new Label();
            groupBox3 = new GroupBox();
            label14 = new Label();
            groupBox4 = new GroupBox();
            label15 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(24, 75);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 22;
            label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(122, 75);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(134, 23);
            txtFirstName.TabIndex = 21;
            // 
            // label2
            // 
            label2.Location = new Point(24, 127);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 20;
            label2.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(122, 127);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(134, 23);
            txtLastName.TabIndex = 19;
            // 
            // label3
            // 
            label3.Location = new Point(24, 228);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 18;
            label3.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(122, 228);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(134, 23);
            txtEmail.TabIndex = 17;
            // 
            // label4
            // 
            label4.Location = new Point(24, 180);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 16;
            label4.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(122, 177);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(134, 23);
            txtAddress.TabIndex = 15;
            // 
            // label5
            // 
            label5.Location = new Point(24, 279);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 14;
            label5.Text = "Phone Number:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(135, 276);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(121, 23);
            txtPhone.TabIndex = 13;
            // 
            // label6
            // 
            label6.Location = new Point(29, 177);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 12;
            label6.Text = "Card Number:";
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(154, 174);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(122, 23);
            txtCardNumber.TabIndex = 11;
            // 
            // label7
            // 
            label7.Location = new Point(29, 127);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 10;
            label7.Text = "PIN:";
            // 
            // txtPin
            // 
            txtPin.Location = new Point(154, 124);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(121, 23);
            txtPin.TabIndex = 9;
            // 
            // label8
            // 
            label8.Location = new Point(29, 75);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 8;
            label8.Text = "Status:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(168, 22);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 49);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(387, 22);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 49);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // label9
            // 
            label9.Font = new Font("Arial Narrow", 36F, FontStyle.Bold);
            label9.Location = new Point(282, 32);
            label9.Name = "label9";
            label9.Size = new Size(497, 58);
            label9.TabIndex = 5;
            label9.Text = "ADD CUSTOMER FORM";
            // 
            // cmbStatus
            // 
            cmbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cmbStatus.Location = new Point(154, 75);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 4;
            // 
            // label10
            // 
            label10.Location = new Point(20, 75);
            label10.Name = "label10";
            label10.Size = new Size(135, 23);
            label10.TabIndex = 3;
            label10.Text = "CustomerUsername";
            // 
            // txtCustomerUsername
            // 
            txtCustomerUsername.Location = new Point(161, 72);
            txtCustomerUsername.Name = "txtCustomerUsername";
            txtCustomerUsername.Size = new Size(100, 23);
            txtCustomerUsername.TabIndex = 2;
            // 
            // label11
            // 
            label11.Location = new Point(20, 127);
            label11.Name = "label11";
            label11.Size = new Size(113, 23);
            label11.TabIndex = 1;
            label11.Text = "CustomerPassword";
            label11.Click += label11_Click;
            // 
            // txtCustomerPassword
            // 
            txtCustomerPassword.Location = new Point(161, 127);
            txtCustomerPassword.Name = "txtCustomerPassword";
            txtCustomerPassword.Size = new Size(100, 23);
            txtCustomerPassword.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Location = new Point(43, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 317);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label12.Location = new Point(52, 28);
            label12.Name = "label12";
            label12.Size = new Size(182, 21);
            label12.TabIndex = 23;
            label12.Text = "Customer Information";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtPin);
            groupBox2.Controls.Add(cmbStatus);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtCardNumber);
            groupBox2.Location = new Point(341, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(289, 215);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label13.Location = new Point(72, 28);
            label13.Name = "label13";
            label13.Size = new Size(144, 21);
            label13.TabIndex = 15;
            label13.Text = "Account Settings";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtCustomerUsername);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtCustomerPassword);
            groupBox3.Location = new Point(646, 143);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(289, 215);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label14.Location = new Point(61, 28);
            label14.Name = "label14";
            label14.Size = new Size(142, 21);
            label14.TabIndex = 4;
            label14.Text = "Login Credentials";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(btnSave);
            groupBox4.Controls.Add(btnCancel);
            groupBox4.Location = new Point(341, 371);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(594, 89);
            groupBox4.TabIndex = 25;
            groupBox4.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label15.Location = new Point(29, 34);
            label15.Name = "label15";
            label15.Size = new Size(67, 21);
            label15.TabIndex = 8;
            label15.Text = "Session";
            // 
            // AddCustomerForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(983, 498);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label9);
            DoubleBuffered = true;
            Name = "AddCustomerForm";
            Text = "AddCustomerForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
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
        private Label label10;
        private TextBox txtCustomerUsername;
        private Label label11;
        private TextBox txtCustomerPassword;
        private GroupBox groupBox1;
        private Label label12;
        private GroupBox groupBox2;
        private Label label13;
        private GroupBox groupBox3;
        private Label label14;
        private GroupBox groupBox4;
        private Label label15;
    }
}
