// we use these to work with data and show windows
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SWE5201BankingSystemHE20882.Services; // this has the logic like getting customer and transactions

namespace SWE5201BankingSystemHE20882
{
    // this form is shown to the customer after they login, like their dashboard
    public partial class CustomerDashboardForm : Form
    {
        private readonly int _customerId; // we store the ID of the person logged in

        // these services help us get customer, account, and transaction data
        private readonly TransactionService transactionService = new TransactionService();
        private readonly CustomerService customerService = new CustomerService();
        private readonly AccountService accountService = new AccountService();

        // when the form is made, we also keep track of the customer ID
        public CustomerDashboardForm(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;

            // this will show a message when a transaction happens
            transactionService.OnTransactionRecorded += (message, timestamp) =>
            {
                MessageBox.Show($"Transaction Log: {message} at {timestamp}", "Transaction Recorded");
            };

            // transaction log shown in console for debugging
            transactionService.OnTransactionRecorded += (msg, time) =>
            {
                Console.WriteLine($"[DEBUG] {time} -> {msg}");
            };

        }


        // when form first loads we auto select first account type and load data
        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {
            if (cmbAccountType.Items.Count > 0)
            {
                cmbAccountType.SelectedIndex = 0;
                string accountType = cmbAccountType.SelectedItem?.ToString() ?? "Savings";
                LoadCustomerDetails(accountType);
                LoadTransactions(accountType);
            }
        }

        // this runs when user changes account type like from savings to current
        private void cmbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAccountType.SelectedItem is string selectedType && !string.IsNullOrEmpty(selectedType))
            {
                LoadCustomerDetails(selectedType);
                LoadTransactions(selectedType);
            }
            else
            {
                MessageBox.Show("Please select a valid account type.");
            }
        }

        // this gets details of customer like name, email and balance
        private void LoadCustomerDetails(string accountType)
        {
            DataRow? row = customerService.GetCustomerAccountDetails(_customerId, accountType);
            if (row != null)
            {
                txtFirstName.Text = row["FirstName"]?.ToString();
                txtLastName.Text = row["LastName"]?.ToString();
                txtEmail.Text = row["Email"]?.ToString();
                txtBalance.Text = row["Balance"]?.ToString();
                txtAccountStatus.Text = row["Status"]?.ToString();
            }
            else
            {
                MessageBox.Show("Customer data not found.");
            }
        }

        // this loads transaction table and sorts it from newest to oldest
        private void LoadTransactions(string accountType)
        {
            DataTable dt = transactionService.GetTransactions(_customerId, accountType);

            if (dt != null && dt.Rows.Count > 0)
            {
                var sortedRows = dt.AsEnumerable()
                    .OrderByDescending(row => row.Field<DateTime>("TransactionDate"));

                dgvTransactions.DataSource = sortedRows.CopyToDataTable();
            }
            else
            {
                dgvTransactions.DataSource = null; // clear if empty
            }
        }

        // when customer clicks deposit button this runs
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            // check if amount is valid number and bigger than 0
            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            // get account type from dropdown
            if (cmbAccountType.SelectedItem is not string accountType || string.IsNullOrWhiteSpace(accountType))
            {
                MessageBox.Show("Please select an account type.");
                return;
            }

            // get account ID for this customer and type
            int accountId = accountService.GetAccountId(_customerId, accountType);
            if (accountId > 0)
            {
                transactionService.RecordTransaction(accountId, "Deposit", amount, DateTime.Now);
                LoadCustomerDetails(accountType); // refresh details
                LoadTransactions(accountType);    // refresh history
            }
            else
            {
                MessageBox.Show("Account not found.");
            }
        }

        // when customer clicks withdraw this does same as deposit but subtracts
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            if (cmbAccountType.SelectedItem is not string accountType || string.IsNullOrWhiteSpace(accountType))
            {
                MessageBox.Show("Please select an account type.");
                return;
            }

            int accountId = accountService.GetAccountId(_customerId, accountType);
            if (accountId > 0)
            {
                transactionService.RecordTransaction(accountId, "Withdraw", amount, DateTime.Now);
                LoadCustomerDetails(accountType);
                LoadTransactions(accountType);
            }
            else
            {
                MessageBox.Show("Account not found.");
            }
        }

        // this button logs out customer and brings them back to login
        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Log_In().Show(); // show login screen
            this.Close();        // close current dashboard
        }

        // these do nothing now, they were auto-made when double clicking a label
        private void label3_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
    }
}
