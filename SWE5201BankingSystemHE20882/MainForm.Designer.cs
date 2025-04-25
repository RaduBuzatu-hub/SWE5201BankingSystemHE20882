namespace SWE5201BankingSystemHE20882
{
    partial class MainForm
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
            btnViewCustomers = new Button();
            btnAddCustomer = new Button();
            btnLogout = new Button();
            dataGridViewCustomers = new DataGridView();
            btnDeleteCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label1.Location = new Point(521, 18);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome, Admin!";
            // 
            // btnViewCustomers
            // 
            btnViewCustomers.Location = new Point(71, 127);
            btnViewCustomers.Name = "btnViewCustomers";
            btnViewCustomers.Size = new Size(164, 34);
            btnViewCustomers.TabIndex = 1;
            btnViewCustomers.Text = "View Customers";
            btnViewCustomers.UseVisualStyleBackColor = true;
            btnViewCustomers.Click += btnViewCustomers_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(71, 198);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(164, 34);
            btnAddCustomer.TabIndex = 2;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(907, 629);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(164, 34);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(274, 127);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 62;
            dataGridViewCustomers.Size = new Size(797, 476);
            dataGridViewCustomers.TabIndex = 4;
            dataGridViewCustomers.CellContentClick += dataGridViewCustomers_CellContentClick;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(71, 273);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(164, 34);
            btnDeleteCustomer.TabIndex = 5;
            btnDeleteCustomer.Text = "Delete Customer";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 685);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(dataGridViewCustomers);
            Controls.Add(btnLogout);
            Controls.Add(btnAddCustomer);
            Controls.Add(btnViewCustomers);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnViewCustomers;
        private Button btnAddCustomer;
        private Button btnLogout;
        private DataGridView dataGridViewCustomers;
        private Button btnDeleteCustomer;
    }
}