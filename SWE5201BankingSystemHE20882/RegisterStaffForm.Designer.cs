namespace SWE5201BankingSystemHE20882
{
    partial class RegisterStaffForm
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
            label2 = new Label();
            label13 = new Label();
            btnRegister = new Button();
            btnCancel = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label1.Location = new Point(367, 47);
            label1.Name = "label1";
            label1.Size = new Size(295, 32);
            label1.TabIndex = 0;
            label1.Text = "Staff Admin Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 134);
            label2.Name = "label2";
            label2.Size = new Size(174, 28);
            label2.TabIndex = 1;
            label2.Text = "Admin Username";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label13.Location = new Point(65, 225);
            label13.Name = "label13";
            label13.Size = new Size(169, 28);
            label13.TabIndex = 12;
            label13.Text = "Admin password";
            label13.Click += label13_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.Location = new Point(293, 315);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(167, 59);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(505, 315);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(167, 59);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(310, 134);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(362, 31);
            txtUsername.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(310, 222);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(362, 31);
            txtPassword.TabIndex = 16;
            // 
            // RegisterStaffForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(label13);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterStaffForm";
            Text = "RegisterStaffForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label13;
        private Button btnRegister;
        private Button btnCancel;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}