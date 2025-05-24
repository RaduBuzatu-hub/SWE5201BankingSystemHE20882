namespace SWE5201BankingSystemHE20882
{
    partial class ManageBankForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBankForm));
            txtBankName = new TextBox();
            txtBankBranch = new TextBox();
            btnAddBank = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCancel = new Button();
            dgvBanks = new DataGridView();
            btnDeleteBank = new Button();
            btnDeleteBranch = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvBanks).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBankName
            // 
            txtBankName.Location = new Point(101, 27);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(170, 23);
            txtBankName.TabIndex = 0;
            // 
            // txtBankBranch
            // 
            txtBankBranch.Location = new Point(101, 78);
            txtBankBranch.Name = "txtBankBranch";
            txtBankBranch.Size = new Size(170, 23);
            txtBankBranch.TabIndex = 1;
            // 
            // btnAddBank
            // 
            btnAddBank.BackColor = Color.Moccasin;
            btnAddBank.Location = new Point(19, 135);
            btnAddBank.Name = "btnAddBank";
            btnAddBank.Size = new Size(119, 34);
            btnAddBank.TabIndex = 2;
            btnAddBank.Text = "Add Bank";
            btnAddBank.UseVisualStyleBackColor = false;
            btnAddBank.Click += btnAddBank_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 30);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 3;
            label1.Text = "Bank Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 81);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 4;
            label2.Text = "Bank Branch:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Moccasin;
            label3.Font = new Font("Segoe UI Variable Display", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(279, 18);
            label3.Name = "label3";
            label3.Size = new Size(348, 49);
            label3.TabIndex = 5;
            label3.Text = "Bank Management";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Moccasin;
            btnCancel.Location = new Point(152, 188);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(119, 34);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // dgvBanks
            // 
            dgvBanks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBanks.Location = new Point(307, 27);
            dgvBanks.Name = "dgvBanks";
            dgvBanks.Size = new Size(463, 195);
            dgvBanks.TabIndex = 7;
            // 
            // btnDeleteBank
            // 
            btnDeleteBank.BackColor = Color.Moccasin;
            btnDeleteBank.Location = new Point(152, 135);
            btnDeleteBank.Name = "btnDeleteBank";
            btnDeleteBank.Size = new Size(119, 35);
            btnDeleteBank.TabIndex = 8;
            btnDeleteBank.Text = "Delete Bank";
            btnDeleteBank.UseVisualStyleBackColor = false;
            btnDeleteBank.Click += btnDeleteBank_Click;
            // 
            // btnDeleteBranch
            // 
            btnDeleteBranch.BackColor = Color.Moccasin;
            btnDeleteBranch.Location = new Point(20, 188);
            btnDeleteBranch.Name = "btnDeleteBranch";
            btnDeleteBranch.Size = new Size(118, 34);
            btnDeleteBranch.TabIndex = 9;
            btnDeleteBranch.Text = "Delete Branch";
            btnDeleteBranch.UseVisualStyleBackColor = false;
            btnDeleteBranch.Click += btnDeleteBranch_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnDeleteBranch);
            groupBox1.Controls.Add(txtBankName);
            groupBox1.Controls.Add(btnDeleteBank);
            groupBox1.Controls.Add(txtBankBranch);
            groupBox1.Controls.Add(dgvBanks);
            groupBox1.Controls.Add(btnAddBank);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(779, 251);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // ManageBankForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(806, 350);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            DoubleBuffered = true;
            Name = "ManageBankForm";
            Text = "ManageBankForm";
            Load += ManageBankForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBanks).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBankName;
        private TextBox txtBankBranch;
        private Button btnAddBank;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCancel;
        private DataGridView dgvBanks;
        private Button btnDeleteBank;
        private Button btnDeleteBranch;
        private GroupBox groupBox1;
    }
}