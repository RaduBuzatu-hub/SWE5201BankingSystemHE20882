namespace SWE5201BankingSystemHE20882
{
    partial class AddATMForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddATMForm));
            groupBox1 = new GroupBox();
            btnCancel = new Button();
            btnAddATM = new Button();
            txtBranchID = new TextBox();
            label6 = new Label();
            txtBankID = new TextBox();
            label5 = new Label();
            txtCashAvailable = new TextBox();
            label4 = new Label();
            txtLocation = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cmbCardType = new ComboBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnAddATM);
            groupBox1.Controls.Add(txtBranchID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtBankID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCashAvailable);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtLocation);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbCardType);
            groupBox1.Location = new Point(12, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(566, 271);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(335, 198);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 43);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddATM
            // 
            btnAddATM.Location = new Point(87, 198);
            btnAddATM.Name = "btnAddATM";
            btnAddATM.Size = new Size(121, 43);
            btnAddATM.TabIndex = 12;
            btnAddATM.Text = "Submit";
            btnAddATM.UseVisualStyleBackColor = true;
            btnAddATM.Click += btnAddATM_Click;
            // 
            // txtBranchID
            // 
            txtBranchID.Location = new Point(402, 89);
            txtBranchID.Name = "txtBranchID";
            txtBranchID.Size = new Size(128, 23);
            txtBranchID.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(315, 92);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 10;
            label6.Text = "Branch ID";
            // 
            // txtBankID
            // 
            txtBankID.Location = new Point(402, 34);
            txtBankID.Name = "txtBankID";
            txtBankID.Size = new Size(128, 23);
            txtBankID.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(315, 37);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 8;
            label5.Text = "Bank ID";
            // 
            // txtCashAvailable
            // 
            txtCashAvailable.Location = new Point(150, 139);
            txtCashAvailable.Name = "txtCashAvailable";
            txtCashAvailable.Size = new Size(121, 23);
            txtCashAvailable.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 142);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 6;
            label4.Text = "Cash Available";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(150, 34);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(121, 23);
            txtLocation.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 37);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 4;
            label3.Text = "Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 92);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 3;
            label2.Text = "Accepted Card Type";
            label2.Click += label2_Click;
            // 
            // cmbCardType
            // 
            cmbCardType.FormattingEnabled = true;
            cmbCardType.Items.AddRange(new object[] { "Master", "Visa" });
            cmbCardType.Location = new Point(150, 89);
            cmbCardType.Name = "cmbCardType";
            cmbCardType.Size = new Size(121, 23);
            cmbCardType.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(253, 49);
            label1.TabIndex = 1;
            label1.Text = "Register ATM";
            // 
            // AddATMForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(595, 394);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "AddATMForm";
            Text = "AddATMForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label6;
        private TextBox txtBankID;
        private Label label5;
        private TextBox txtCashAvailable;
        private Label label4;
        private TextBox txtLocation;
        private Label label3;
        private Label label2;
        private ComboBox cmbCardType;
        private Button btnCancel;
        private Button btnAddATM;
        private TextBox txtBranchID;
    }
}