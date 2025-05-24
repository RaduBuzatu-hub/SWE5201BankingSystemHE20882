using System;                           // this gives us basic things like strings, numbers and errors
using System.Data;                      // we use this to work with DataTable to hold data
using Microsoft.Data.SqlClient;        // used for talking to SQL Server (not used directly here)
using System.Windows.Forms;            // we need this to build forms and UI stuff
using SWE5201BankingSystemHE20882.Services; // this is where we bring in the services like TransactionService

namespace SWE5201BankingSystemHE20882
{
    // this form is for admins to check the customer transactions history
    public partial class AdminTransactionViewerForm : Form
    {
        // this is the constructor. when we open the form this will run
        public AdminTransactionViewerForm()
        {
            InitializeComponent(); // this sets up all the UI stuff like textboxes, buttons etc
        }

        // this creates a new transaction service to help us get the data from the database
        private readonly TransactionService _transactionService = new TransactionService();

        // this method is for loading transaction data using customer ID and account type
        private void LoadTransactionHistory(int customerId, string accountType)
        {
            // we call the service to get the data and show it in the grid
            DataTable dt = _transactionService.GetTransactions(customerId, accountType);
            dgvTransactions.DataSource = dt; // put the data inside the data grid
        }

        // this runs when the admin clicks the search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // get what admin typed in customer ID box and remove spaces
            string customerIdText = txtCustomerID.Text.Trim();
            // get the account type they selected from the dropdown
            string? selectedAccountType = cmbAccountType.SelectedItem?.ToString();

            // if they didn’t pick account type we show message
            if (string.IsNullOrWhiteSpace(selectedAccountType))
            {
                MessageBox.Show("Please select an Account Type.");
                return;
            }

            // store the account type now that we know it's not empty
            string accountType = selectedAccountType;

            // check if customer ID is a number and if account type is picked
            if (!int.TryParse(customerIdText, out int customerId) || string.IsNullOrEmpty(accountType))
            {
                MessageBox.Show("Please enter a valid Customer ID and select an Account Type.");
                return;
            }

            // if all is okay then load the transaction history
            LoadTransactionHistory(customerId, accountType);
        }

        // this is for when we click the close button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // just close the form
        }
    }
}
