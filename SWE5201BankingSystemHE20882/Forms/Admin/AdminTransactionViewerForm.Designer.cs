namespace SWE5201BankingSystemHE20882
{
    partial class AdminTransactionViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTransactionViewerForm));
            label1 = new Label();
            txtCustomerID = new TextBox();
            label2 = new Label();
            cmbAccountType = new ComboBox();
            dgvTransactions = new DataGridView();
            btnSearch = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 65);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(116, 62);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(154, 23);
            txtCustomerID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 128);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Account Type:";
            // 
            // cmbAccountType
            // 
            cmbAccountType.FormattingEnabled = true;
            cmbAccountType.Items.AddRange(new object[] { "Savings", "Current" });
            cmbAccountType.Location = new Point(134, 125);
            cmbAccountType.Name = "cmbAccountType";
            cmbAccountType.Size = new Size(136, 23);
            cmbAccountType.TabIndex = 3;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(16, 62);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.Size = new Size(409, 151);
            dgvTransactions.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Moccasin;
            btnSearch.Location = new Point(34, 171);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(107, 42);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Moccasin;
            button2.Location = new Point(160, 171);
            button2.Name = "button2";
            button2.Size = new Size(110, 42);
            button2.TabIndex = 6;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCustomerID);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbAccountType);
            groupBox1.Location = new Point(12, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 232);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(90, 19);
            label3.Name = "label3";
            label3.Size = new Size(134, 21);
            label3.TabIndex = 8;
            label3.Text = "Customer Search";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Info;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dgvTransactions);
            groupBox2.Location = new Point(345, 111);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(443, 232);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(127, 9);
            label4.Name = "label4";
            label4.Size = new Size(132, 21);
            label4.TabIndex = 9;
            label4.Text = "Transaction View";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(249, 25);
            label5.Name = "label5";
            label5.Size = new Size(351, 49);
            label5.TabIndex = 9;
            label5.Text = "Transaction Details";
            // 
            // AdminTransactionViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 366);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "AdminTransactionViewerForm";
            Text = "AdminTransactionViewerForm";
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCustomerID;
        private Label label2;
        private ComboBox cmbAccountType;
        private DataGridView dgvTransactions;
        private Button btnSearch;
        private Button button2;
        private GroupBox groupBox1;
        private Label label3;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
    }
}