using System;                          // gives us basic stuff like string, int, etc.
using System.Data;                     // helps work with tables and rows
using System.Windows.Forms;           // this lets us make windows and buttons and forms
using SWE5201BankingSystemHE20882.Services; // we use this to get access to our service classes like CustomerService

namespace SWE5201BankingSystemHE20882
{
    // this is the main form that admins see after login
    public partial class MainForm : Form
    {
        // we create services to talk to database stuff (like get or delete customers, accounts, banks, etc.)
        private readonly CustomerService _customerService = new CustomerService();
        private readonly AccountService _accountService = new AccountService();
        private readonly BankService _bankService = new BankService();
        private readonly ATMService _atmService = new ATMService();

        // this sets up the form and buttons and everything
        public MainForm()
        {
            InitializeComponent();
        }

        // this happens when we press logout button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart(); // restart the whole app (goes back to login form)
        }

        // this shows a list of all customers in the table (grid)
        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            dataGridMain.DataSource = _customerService.GetAllCustomers();
        }

        // this opens a form where admin can add a new customer
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            new AddCustomerForm().ShowDialog(); // opens a popup form
        }

        // this deletes the selected customer (only if a row is selected)
        private void btnDeleteCustomer_Click_1(object sender, EventArgs e)
        {
            if (dataGridMain.SelectedRows.Count == 0) // if no row clicked
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            // get the customer id from the selected row
            int customerId = Convert.ToInt32(dataGridMain.SelectedRows[0].Cells["CustomerID"].Value);

            // call the delete function
            string message = _customerService.DeleteCustomerAndInactiveAccounts(customerId);
            MessageBox.Show(message);

            btnViewCustomers.PerformClick(); // reloads the customer list
        }

        // opens a form where admin can make a new account
        private void btnCreateAccount_Click_1(object sender, EventArgs e)
        {
            new CreateAccountForm().ShowDialog();
        }

        // shows all accounts with bank and branch info
        private void btnViewAccounts_Click(object sender, EventArgs e)
        {
            dataGridMain.DataSource = _accountService.GetAllAccountsWithBranches();
        }

        // deletes account if it's inactive
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (dataGridMain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an account to delete.");
                return;
            }

            var selectedRow = dataGridMain.SelectedRows[0];
            if (selectedRow == null)
            {
                MessageBox.Show("Unexpected error: No row selected.");
                return;
            }

            int accountId = Convert.ToInt32(selectedRow.Cells["AccountID"].Value);
            string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";

            // don't let them delete if account is active
            if (status.Equals("Active", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Cannot delete active accounts.");
                return;
            }

            string message = _accountService.DeleteAccount(accountId);
            MessageBox.Show(message);
            btnViewAccounts.PerformClick(); // reload account list
        }

        // shows all banks and their branches
        private void btnViewBanks_Click(object sender, EventArgs e)
        {
            dataGridMain.DataSource = _bankService.GetBankAndBranchList();
        }

        // opens a form where admin can add or manage banks and branches
        private void button1_Click(object sender, EventArgs e)
        {
            new ManageBankForm().ShowDialog();
        }

        // opens form to edit customer and their account details
        private void btnModifyCustomerAccount_Click(object sender, EventArgs e)
        {
            using (var modifyForm = new ModifyDetailsForm())
            {
                modifyForm.StartPosition = FormStartPosition.CenterParent;
                modifyForm.ShowDialog(this); // opens the form and locks the main one until closed
            }
        }

        // opens the form to add new ATM
        private void btnAddATM_Click(object sender, EventArgs e)
        {
            new AddATMForm().ShowDialog();
        }

        // shows all ATMs with their bank and branch info
        private void btnViewATMs_Click(object sender, EventArgs e)
        {
            dataGridMain.DataSource = _atmService.GetAllATMsWithBankBranch();
        }

        // deletes selected ATM
        private void btnDeleteATM_Click(object sender, EventArgs e)
        {
            if (dataGridMain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an ATM to delete.");
                return;
            }

            int atmId = Convert.ToInt32(dataGridMain.SelectedRows[0].Cells["ATMID"].Value);
            string message = _atmService.DeleteATM(atmId);
            MessageBox.Show(message);

            btnViewATMs.PerformClick(); // reloads ATM list
        }

        // opens the transaction history form
        private void btnATMTransactions_Click(object sender, EventArgs e)
        {
            new AdminTransactionViewerForm().Show(); // this doesn't lock the main form
        }

        // these are empty functions, sometimes auto made when double click something in designer
        private void MainForm_Load(object sender, EventArgs e) { }
        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}
