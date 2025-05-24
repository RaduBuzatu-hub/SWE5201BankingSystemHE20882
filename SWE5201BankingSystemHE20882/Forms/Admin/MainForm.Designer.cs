namespace SWE5201BankingSystemHE20882
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnViewCustomers = new Button();
            btnAddCustomer = new Button();
            btnLogout = new Button();
            dataGridMain = new DataGridView();
            btnDeleteCustomer = new Button();
            btnCreateAccount = new Button();
            button1 = new Button();
            btnViewAccounts = new Button();
            btnViewBanks = new Button();
            btnModifyCustomerAccount = new Button();
            label2 = new Label();
            label3 = new Label();
            btnDeleteAccount = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            groupBox5 = new GroupBox();
            btnATMTransactions = new Button();
            label8 = new Label();
            groupBox6 = new GroupBox();
            btnDeleteATM = new Button();
            btnAddATM = new Button();
            btnViewATMs = new Button();
            label7 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridMain).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // btnViewCustomers
            // 
            btnViewCustomers.Location = new Point(5, 50);
            btnViewCustomers.Margin = new Padding(2);
            btnViewCustomers.Name = "btnViewCustomers";
            btnViewCustomers.Size = new Size(191, 34);
            btnViewCustomers.TabIndex = 1;
            btnViewCustomers.Text = "View Customers";
            btnViewCustomers.UseVisualStyleBackColor = true;
            btnViewCustomers.Click += btnViewCustomers_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(5, 97);
            btnAddCustomer.Margin = new Padding(2);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(191, 34);
            btnAddCustomer.TabIndex = 2;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.Location = new Point(581, 206);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(166, 34);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dataGridMain
            // 
            dataGridMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMain.Location = new Point(11, 50);
            dataGridMain.Margin = new Padding(2);
            dataGridMain.Name = "dataGridMain";
            dataGridMain.RowHeadersWidth = 62;
            dataGridMain.Size = new Size(736, 146);
            dataGridMain.TabIndex = 4;
            dataGridMain.CellContentClick += dataGridViewCustomers_CellContentClick;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(6, 197);
            btnDeleteCustomer.Margin = new Padding(2);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(191, 34);
            btnDeleteCustomer.TabIndex = 5;
            btnDeleteCustomer.Text = "Delete Customer";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click_1;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(6, 114);
            btnCreateAccount.Margin = new Padding(2);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(191, 34);
            btnCreateAccount.TabIndex = 6;
            btnCreateAccount.Text = "Add Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(6, 112);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(182, 34);
            button1.TabIndex = 7;
            button1.Text = "Bank Management";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnViewAccounts
            // 
            btnViewAccounts.Location = new Point(5, 68);
            btnViewAccounts.Name = "btnViewAccounts";
            btnViewAccounts.Size = new Size(191, 32);
            btnViewAccounts.TabIndex = 8;
            btnViewAccounts.Text = "View Accounts";
            btnViewAccounts.UseVisualStyleBackColor = true;
            btnViewAccounts.Click += btnViewAccounts_Click;
            // 
            // btnViewBanks
            // 
            btnViewBanks.Location = new Point(6, 64);
            btnViewBanks.Name = "btnViewBanks";
            btnViewBanks.Size = new Size(182, 34);
            btnViewBanks.TabIndex = 9;
            btnViewBanks.Text = "View Banks";
            btnViewBanks.UseVisualStyleBackColor = true;
            btnViewBanks.Click += btnViewBanks_Click;
            // 
            // btnModifyCustomerAccount
            // 
            btnModifyCustomerAccount.Location = new Point(6, 148);
            btnModifyCustomerAccount.Name = "btnModifyCustomerAccount";
            btnModifyCustomerAccount.Size = new Size(190, 34);
            btnModifyCustomerAccount.TabIndex = 10;
            btnModifyCustomerAccount.Text = "Edit Details";
            btnModifyCustomerAccount.UseVisualStyleBackColor = true;
            btnModifyCustomerAccount.Click += btnModifyCustomerAccount_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 21);
            label2.TabIndex = 11;
            label2.Text = "Customer Management";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 19);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(181, 21);
            label3.TabIndex = 12;
            label3.Text = "Account Management";
            label3.Click += label3_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(5, 162);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(191, 37);
            btnDeleteAccount.TabIndex = 13;
            btnDeleteAccount.Text = "Delete Account";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 22);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 21);
            label4.TabIndex = 14;
            label4.Text = "Bank Management";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnModifyCustomerAccount);
            groupBox1.Controls.Add(btnViewCustomers);
            groupBox1.Controls.Add(btnAddCustomer);
            groupBox1.Controls.Add(btnDeleteCustomer);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(190, 281);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 245);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnViewAccounts);
            groupBox2.Controls.Add(btnCreateAccount);
            groupBox2.Controls.Add(btnDeleteAccount);
            groupBox2.Location = new Point(190, 587);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 205);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnViewBanks);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(474, 587);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 205);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(btnLogout);
            groupBox4.Controls.Add(dataGridMain);
            groupBox4.Location = new Point(474, 281);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(780, 245);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(500, 211);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
            label5.TabIndex = 15;
            label5.Text = "Session";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 14);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 12;
            label6.Text = "View Data";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnATMTransactions);
            groupBox5.Controls.Add(label8);
            groupBox5.Location = new Point(1048, 588);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(206, 204);
            groupBox5.TabIndex = 19;
            groupBox5.TabStop = false;
            // 
            // btnATMTransactions
            // 
            btnATMTransactions.Location = new Point(30, 63);
            btnATMTransactions.Name = "btnATMTransactions";
            btnATMTransactions.Size = new Size(143, 34);
            btnATMTransactions.TabIndex = 20;
            btnATMTransactions.Text = "View Transactions";
            btnATMTransactions.UseVisualStyleBackColor = true;
            btnATMTransactions.Click += btnATMTransactions_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(30, 22);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(143, 21);
            label8.TabIndex = 19;
            label8.Text = "ATM Transactions";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnDeleteATM);
            groupBox6.Controls.Add(btnAddATM);
            groupBox6.Controls.Add(btnViewATMs);
            groupBox6.Controls.Add(label7);
            groupBox6.Location = new Point(761, 587);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(192, 205);
            groupBox6.TabIndex = 20;
            groupBox6.TabStop = false;
            // 
            // btnDeleteATM
            // 
            btnDeleteATM.Location = new Point(23, 161);
            btnDeleteATM.Name = "btnDeleteATM";
            btnDeleteATM.Size = new Size(149, 37);
            btnDeleteATM.TabIndex = 18;
            btnDeleteATM.Text = "Delete ATM";
            btnDeleteATM.UseVisualStyleBackColor = true;
            btnDeleteATM.Click += btnDeleteATM_Click;
            // 
            // btnAddATM
            // 
            btnAddATM.Location = new Point(23, 112);
            btnAddATM.Name = "btnAddATM";
            btnAddATM.Size = new Size(149, 34);
            btnAddATM.TabIndex = 17;
            btnAddATM.Text = "Add ATM";
            btnAddATM.UseVisualStyleBackColor = true;
            btnAddATM.Click += btnAddATM_Click;
            // 
            // btnViewATMs
            // 
            btnViewATMs.Location = new Point(23, 64);
            btnViewATMs.Name = "btnViewATMs";
            btnViewATMs.Size = new Size(149, 34);
            btnViewATMs.TabIndex = 16;
            btnViewATMs.Text = "View ATM";
            btnViewATMs.UseVisualStyleBackColor = true;
            btnViewATMs.Click += btnViewATMs_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 22);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(149, 21);
            label7.TabIndex = 15;
            label7.Text = "ATM Management";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 36F, FontStyle.Bold);
            label1.Location = new Point(474, 114);
            label1.Name = "label1";
            label1.Size = new Size(617, 57);
            label1.TabIndex = 21;
            label1.Text = "ADMINISTRATOR DASHBOARD";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1604, 881);
            Controls.Add(label1);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridMain).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnViewCustomers;
        private Button btnAddCustomer;
        private Button btnLogout;
        private DataGridView dataGridMain;
        private Button btnDeleteCustomer;
        private Button btnCreateAccount;
        private Button button1;
        private Button btnViewAccounts;
        private Button btnViewBanks;
        private Button btnModifyCustomerAccount;
        private Label label2;
        private Label label3;
        private Button btnDeleteAccount;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label5;
        private Label label6;
        private GroupBox groupBox6;
        private Label label7;
        private Button btnDeleteATM;
        private Button btnAddATM;
        private Button btnViewATMs;
        private Button btnATMTransactions;
        private Label label8;
        private Label label1;
    }
}