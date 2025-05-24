// we need these things for the form to work, to use data and to talk to the database
using System;
using System.Data;
using System.Windows.Forms;
using SWE5201BankingSystemHE20882.Services;

namespace SWE5201BankingSystemHE20882
{
    // this is the screen (form) where admin can make new bank account for customers
    public partial class CreateAccountForm : Form
    {
        // we get the services that help us do stuff with accounts, banks and customers
        private readonly AccountService _accountService = new AccountService();
        private readonly BankService _bankService = new BankService();
        private readonly CustomerService _customerService = new CustomerService();

        // when the form opens this runs and sets up the screen
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        // this button is for closing the form if admin clicks cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // this runs when admin clicks the create button to add the new account
        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            try
            {
                // we check if the customer ID and balance are typed properly (must be numbers)
                if (!int.TryParse(txtCustomerID.Text.Trim(), out int customerId) ||
                    !decimal.TryParse(txtBalance.Text.Trim(), out decimal balance))
                {
                    MessageBox.Show("Please enter valid numeric values for Customer ID and Balance.");
                    return;
                }

                // get values from dropdowns and textboxes
                string? accountType = cmbAccountType.SelectedItem?.ToString(); // like "Savings" or "Current"
                string? status = cmbStatus.SelectedItem?.ToString();           // like "Active" or "Inactive"
                string bankName = txtBankID.Text.Trim();                       // bank name entered
                string bankBranch = txtBankBranch.Text.Trim();                 // branch name entered

                // check if any of them are missing
                if (string.IsNullOrWhiteSpace(accountType) ||
                    string.IsNullOrWhiteSpace(status) ||
                    string.IsNullOrWhiteSpace(bankName) ||
                    string.IsNullOrWhiteSpace(bankBranch))
                {
                    MessageBox.Show("Please fill out all fields.");
                    return;
                }

                // now we check if the customer ID is in the system
                var customer = _customerService.GetCustomerById(customerId);
                if (customer == null)
                {
                    MessageBox.Show("Customer ID not found. Please check and try again.");
                    return;
                }

                // get the branch ID using the bank name and branch name
                int? branchId = _bankService.GetBranchId(bankName, bankBranch);
                if (branchId == null)
                {
                    MessageBox.Show("Bank branch not found. Please verify bank name and branch.");
                    return;
                }

                // get the actual bank ID from just the bank name
                int? bankId = _bankService.GetBankIdByName(bankName);
                if (bankId == null)
                {
                    MessageBox.Show("Bank not found. Please check the bank name.");
                    return;
                }

                // finally, try to create the new account in the system
                bool success = _accountService.CreateAccount(customerId, accountType, balance, bankId.Value, branchId.Value, status);

                if (success)
                {
                    MessageBox.Show("Account created successfully!");
                    this.Close(); // close the form when it's done
                }
                else
                {
                    MessageBox.Show("Account already exists for this customer and type."); // already made
                }
            }
            catch
            {
                // if something breaks this message will show up
                MessageBox.Show("An error occurred while creating the account.\n" +
                                "Please ensure all details are correct and no duplicate account exists.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // these are just auto-generated empty methods from the form designer
        private void label7_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}
