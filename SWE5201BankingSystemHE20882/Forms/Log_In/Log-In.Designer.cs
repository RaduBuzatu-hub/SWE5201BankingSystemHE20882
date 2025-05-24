namespace SWE5201BankingSystemHE20882
{
    partial class Log_In
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_In));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnCustomerLogin = new Button();
            label1 = new Label();
            lblPassword = new Label();
            btnBankStaffLogin = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Info;
            txtUsername.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold);
            txtUsername.Location = new Point(799, 382);
            txtUsername.Margin = new Padding(2);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(247, 44);
            txtUsername.TabIndex = 2;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Info;
            txtPassword.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold);
            txtPassword.Location = new Point(799, 490);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(247, 39);
            txtPassword.TabIndex = 3;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnCustomerLogin
            // 
            btnCustomerLogin.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerLogin.Location = new Point(799, 603);
            btnCustomerLogin.Margin = new Padding(2);
            btnCustomerLogin.Name = "btnCustomerLogin";
            btnCustomerLogin.Size = new Size(247, 109);
            btnCustomerLogin.TabIndex = 4;
            btnCustomerLogin.Text = "Customer Login";
            btnCustomerLogin.UseVisualStyleBackColor = true;
            btnCustomerLogin.Click += btnCustomerLogin_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(506, 382);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 44);
            label1.TabIndex = 7;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_2;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(506, 490);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(240, 40);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = ContentAlignment.MiddleCenter;
            lblPassword.Click += lblPassword_Click;
            // 
            // btnBankStaffLogin
            // 
            btnBankStaffLogin.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBankStaffLogin.Location = new Point(506, 603);
            btnBankStaffLogin.Margin = new Padding(2);
            btnBankStaffLogin.Name = "btnBankStaffLogin";
            btnBankStaffLogin.Size = new Size(240, 109);
            btnBankStaffLogin.TabIndex = 9;
            btnBankStaffLogin.Text = "Admin Login";
            btnBankStaffLogin.UseVisualStyleBackColor = true;
            btnBankStaffLogin.Click += btnBankStaffLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(678, 49);
            label2.Name = "label2";
            label2.Size = new Size(230, 57);
            label2.TabIndex = 10;
            label2.Text = "WELCOME";
            // 
            // Log_In
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1604, 881);
            Controls.Add(label2);
            Controls.Add(btnBankStaffLogin);
            Controls.Add(lblPassword);
            Controls.Add(label1);
            Controls.Add(btnCustomerLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            DoubleBuffered = true;
            Margin = new Padding(2);
            MinimumSize = new Size(1598, 850);
            Name = "Log_In";
            Text = "Log_In";
            Load += Log_In_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnCustomerLogin;
        private Label label1;
        private Label lblPassword;
        private Button btnBankStaffLogin;
        private Label label2;
    }
}