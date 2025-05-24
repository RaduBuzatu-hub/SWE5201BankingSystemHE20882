namespace SWE5201BankingSystemHE20882
{
    partial class CustomerDashboardForm : Form
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboardForm));
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtAccountStatus = new TextBox();
            cmbAccountType = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            txtBalance = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtLastName = new TextBox();
            label5 = new Label();
            txtFirstName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnWithdraw = new Button();
            btnDeposit = new Button();
            txtAmount = new TextBox();
            label10 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            dgvTransactions = new DataGridView();
            label11 = new Label();
            groupBox4 = new GroupBox();
            btnLogout = new Button();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(576, 78);
            label1.Name = "label1";
            label1.Size = new Size(390, 49);
            label1.TabIndex = 1;
            label1.Text = "Customer Dashboard";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAccountStatus);
            groupBox1.Controls.Add(cmbAccountType);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtBalance);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(55, 210);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(276, 588);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // txtAccountStatus
            // 
            txtAccountStatus.Location = new Point(113, 506);
            txtAccountStatus.Name = "txtAccountStatus";
            txtAccountStatus.ReadOnly = true;
            txtAccountStatus.Size = new Size(121, 23);
            txtAccountStatus.TabIndex = 15;
            // 
            // cmbAccountType
            // 
            cmbAccountType.FormattingEnabled = true;
            cmbAccountType.Items.AddRange(new object[] { "Savings", "Current" });
            cmbAccountType.Location = new Point(113, 431);
            cmbAccountType.Name = "cmbAccountType";
            cmbAccountType.Size = new Size(121, 23);
            cmbAccountType.TabIndex = 14;
            cmbAccountType.SelectedIndexChanged += cmbAccountType_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 509);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 13;
            label9.Text = "Account Status:";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 434);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 12;
            label8.Text = "Account type:";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(103, 355);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(131, 23);
            txtBalance.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 358);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 10;
            label7.Text = "Balance:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(103, 264);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(131, 23);
            txtEmail.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 267);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 8;
            label6.Text = "Email:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(103, 164);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(131, 23);
            txtLastName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 167);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 6;
            label5.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(103, 73);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(131, 23);
            txtFirstName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 76);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 4;
            label4.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(49, 19);
            label2.Name = "label2";
            label2.Size = new Size(172, 21);
            label2.TabIndex = 3;
            label2.Text = "Customer Information";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnWithdraw);
            groupBox2.Controls.Add(btnDeposit);
            groupBox2.Controls.Add(txtAmount);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(383, 210);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(898, 265);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(516, 178);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(126, 41);
            btnWithdraw.TabIndex = 8;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(193, 178);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(127, 41);
            btnDeposit.TabIndex = 7;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(393, 104);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(142, 23);
            txtAmount.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(279, 104);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 5;
            label10.Text = "Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(343, 19);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 4;
            label3.Text = "ATM Actions";
            label3.Click += label3_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvTransactions);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(383, 506);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1195, 292);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(18, 49);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.Size = new Size(1154, 220);
            dgvTransactions.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(561, 19);
            label11.Name = "label11";
            label11.Size = new Size(151, 21);
            label11.TabIndex = 9;
            label11.Text = "Transaction History";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnLogout);
            groupBox4.Controls.Add(label12);
            groupBox4.Location = new Point(1308, 210);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(263, 265);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(81, 119);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(113, 100);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(104, 19);
            label12.Name = "label12";
            label12.Size = new Size(65, 21);
            label12.TabIndex = 0;
            label12.Text = "Session";
            // 
            // CustomerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1604, 808);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "CustomerDashboardForm";
            Text = "CustomerDashboardForm";
            Load += CustomerDashboardForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label6;
        private TextBox txtLastName;
        private Label label5;
        private TextBox txtFirstName;
        private Label label9;
        private Label label8;
        private TextBox txtBalance;
        private Label label7;
        private TextBox txtEmail;
        private Button btnWithdraw;
        private Button btnDeposit;
        private TextBox txtAmount;
        private Label label10;
        private GroupBox groupBox3;
        private Label label11;
        private DataGridView dgvTransactions;
        private GroupBox groupBox4;
        private Button btnLogout;
        private Label label12;
        private TextBox txtAccountStatus;
        private ComboBox cmbAccountType;
    }
}