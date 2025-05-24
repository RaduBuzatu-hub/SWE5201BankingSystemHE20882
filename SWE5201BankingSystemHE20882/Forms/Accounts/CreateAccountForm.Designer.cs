namespace SWE5201BankingSystemHE20882
{
    partial class CreateAccountForm
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

        /// <summary>
        /// This method initializes and arranges all visual elements (labels, textboxes, buttons) in the form.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountForm));
            label1 = new Label();
            label2 = new Label();
            txtCustomerID = new TextBox();
            label3 = new Label();
            cmbAccountType = new ComboBox();
            label4 = new Label();
            txtBalance = new TextBox();
            label5 = new Label();
            txtBankID = new TextBox();
            btnCreate = new Button();
            btnCancel = new Button();
            label6 = new Label();
            cmbStatus = new ComboBox();
            label7 = new Label();
            txtBankBranch = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 40);
            label1.Name = "label1";
            label1.Size = new Size(281, 43);
            label1.TabIndex = 14;
            label1.Text = "Add New Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 30);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 13;
            label2.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(253, 22);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(187, 23);
            txtCustomerID.TabIndex = 12;
            txtCustomerID.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 77);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 11;
            label3.Text = "Account Type:";
            // 
            // cmbAccountType
            // 
            cmbAccountType.FormattingEnabled = true;
            cmbAccountType.Items.AddRange(new object[] { "Savings", "Current" });
            cmbAccountType.Location = new Point(253, 69);
            cmbAccountType.Name = "cmbAccountType";
            cmbAccountType.Size = new Size(187, 23);
            cmbAccountType.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 204);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 9;
            label4.Text = "Initial Balance:";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(253, 196);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(187, 23);
            txtBalance.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 123);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 7;
            label5.Text = "Bank Name:";
            // 
            // txtBankID
            // 
            txtBankID.Location = new Point(253, 115);
            txtBankID.Name = "txtBankID";
            txtBankID.Size = new Size(187, 23);
            txtBankID.TabIndex = 6;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(55, 292);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(163, 37);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Add Account";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(253, 292);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(187, 37);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 247);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 3;
            label6.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cmbStatus.Location = new Point(253, 247);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(187, 23);
            cmbStatus.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 164);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 1;
            label7.Text = "Branch Name:";
            label7.Click += label7_Click;
            // 
            // txtBankBranch
            // 
            txtBankBranch.Location = new Point(253, 156);
            txtBankBranch.Name = "txtBankBranch";
            txtBankBranch.Size = new Size(187, 23);
            txtBankBranch.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBankBranch);
            groupBox1.Controls.Add(txtCustomerID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbStatus);
            groupBox1.Controls.Add(cmbAccountType);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(txtBalance);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtBankID);
            groupBox1.Location = new Point(12, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 347);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(548, 484);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "CreateAccountForm";
            Text = "CreateAccountForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCustomerID;
        private Label label3;
        private ComboBox cmbAccountType;
        private Label label4;
        private TextBox txtBalance;
        private Label label5;
        private TextBox txtBankID;
        private Button btnCreate;
        private Button btnCancel;
        private Label label6;
        private ComboBox cmbStatus;
        private Label label7;
        private TextBox txtBankBranch;
        private GroupBox groupBox1;
    }
}
