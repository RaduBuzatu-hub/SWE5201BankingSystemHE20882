namespace SWE5201BankingSystemHE20882
{
    partial class Log_In
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnCustomerLogin = new Button();
            label1 = new Label();
            lblPassword = new Label();
            btnBankStaffLogin = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Info;
            txtUsername.Location = new Point(317, 318);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 31);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Info;
            txtPassword.Location = new Point(317, 413);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 31);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnCustomerLogin
            // 
            btnCustomerLogin.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            btnCustomerLogin.Location = new Point(387, 520);
            btnCustomerLogin.Name = "btnCustomerLogin";
            btnCustomerLogin.Size = new Size(230, 38);
            btnCustomerLogin.TabIndex = 4;
            btnCustomerLogin.Text = "Customer Login";
            btnCustomerLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label1.Location = new Point(119, 315);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 7;
            label1.Text = "Username";
            label1.Click += label1_Click_2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblPassword.Location = new Point(119, 416);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(122, 32);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // btnBankStaffLogin
            // 
            btnBankStaffLogin.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            btnBankStaffLogin.Location = new Point(119, 520);
            btnBankStaffLogin.Name = "btnBankStaffLogin";
            btnBankStaffLogin.Size = new Size(230, 38);
            btnBankStaffLogin.TabIndex = 9;
            btnBankStaffLogin.Text = "Admin Login";
            btnBankStaffLogin.UseVisualStyleBackColor = true;
            btnBankStaffLogin.Click += btnBankStaffLogin_Click;
            // 
            // Log_In
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.BankLogo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(787, 690);
            Controls.Add(btnBankStaffLogin);
            Controls.Add(lblPassword);
            Controls.Add(label1);
            Controls.Add(btnCustomerLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            DoubleBuffered = true;
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
    }
}