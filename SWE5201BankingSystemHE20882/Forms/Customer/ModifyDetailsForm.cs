using System; // lets us use stuff like string, int, exceptions
using System.Windows.Forms; // this is for buttons, textboxes, forms
using SWE5201BankingSystemHE20882.Services; // this gives us access to service classes

namespace SWE5201BankingSystemHE20882
{
    // this form lets admin update customer and account info
    public partial class ModifyDetailsForm : Form
    {
        private int customerId; // store customer ID to use later

        // we use service classes to get and update data
        private readonly CustomerService customerService = new CustomerService();
        private readonly AccountService accountService = new AccountService();
        private readonly BankService bankService = new BankService();

        // this runs when form is made
        public ModifyDetailsForm()
        {
            InitializeComponent(); // builds form

            // make sure only correct keys are allowed
            txtFirstName.KeyPress += OnlyAllowLetters;
            txtLastName.KeyPress += OnlyAllowLetters;

            txtPhone.KeyPress += (s, e) => LimitDigits(s, e, 11);
            txtCardNumber.KeyPress += (s, e) => LimitDigits(s, e, 16);
            txtPIN.KeyPress += (s, e) => LimitDigits(s, e, 4);
            txtBalance.KeyPress += OnlyAllowNumbers;
        }

        // overloaded constructor with customer id — calls the first constructor too
        public ModifyDetailsForm(int customerId) : this()
        {
            this.customerId = customerId; // save the id
            LoadCustomerDetails(); // fill form with customer info
            LoadAccountDetails(); // fill form with account info
        }

        // load customer info from database and show in form
        private void LoadCustomerDetails()
        {
            var customer = customerService.GetCustomerById(customerId);
            if (customer != null)
            {
                txtCustomerID.Text = customerId.ToString();
                txtFirstName.Text = customer["FirstName"].ToString();
                txtLastName.Text = customer["LastName"].ToString();
                txtEmail.Text = customer["Email"].ToString();
                txtAddress.Text = customer["Address"].ToString();
                txtPhone.Text = customer["PhoneNumber"].ToString();
                txtCardNumber.Text = customer["CardNumber"].ToString();
                txtPIN.Text = customer["PIN"].ToString();
                cmbCustomerStatus.SelectedItem = customer["Status"].ToString();
                txtCustomerUsername.Text = customer["CustomerUsername"].ToString();
                txtCustomerPassword.Text = customer["CustomerPassword"].ToString();
            }
        }

        // load account info from database
        private void LoadAccountDetails()
        {
            var account = accountService.GetAccountByCustomerId(customerId);
            if (account != null)
            {
                txtBalance.Text = account["Balance"].ToString();
                cmbAccountType.SelectedItem = account["AccountType"].ToString();
                cmbAccountStatus.SelectedItem = account["Status"].ToString();

                // try to get bank and branch info
                if (int.TryParse(account["BankID"].ToString(), out int bankId) &&
                    int.TryParse(account["BranchID"].ToString(), out int branchId))
                {
                    var bankInfo = bankService.GetBankAndBranchName(bankId, branchId);
                    if (bankInfo != null)
                    {
                        txtBankName.Text = bankInfo.Item1;
                        txtBankBranch.Text = bankInfo.Item2;
                    }
                    else
                    {
                        txtBankName.Text = "Unknown Bank";
                        txtBankBranch.Text = "Unknown Branch";
                    }
                }
            }
        }

        // when Find button clicked, try to get customer by ID
        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCustomerID.Text.Trim(), out customerId))
            {
                MessageBox.Show("Please enter a valid Customer ID.");
                return;
            }

            var customer = customerService.GetCustomerById(customerId);
            if (customer == null)
            {
                MessageBox.Show("Customer not found.");
                return;
            }

            LoadCustomerDetails(); // show customer info
            LoadAccountDetails();  // show account info
        }

        // when Save button clicked, update the info
        private void btnSave_Click(object sender, EventArgs e)
        {
            string bankName = txtBankName.Text.Trim();
            string bankBranch = txtBankBranch.Text.Trim();

            // make sure required fields are filled
            if (string.IsNullOrWhiteSpace(bankName) || string.IsNullOrWhiteSpace(bankBranch))
            {
                MessageBox.Show("Bank Name and Branch cannot be empty.");
                return;
            }

            if (txtPIN.Text.Length != 4)
            {
                MessageBox.Show("PIN must be exactly 4 digits.");
                return;
            }

            if (txtCardNumber.Text.Length != 16)
            {
                MessageBox.Show("Card Number must be 16 digits.");
                return;
            }

            if (txtPhone.Text.Length < 7 || txtPhone.Text.Length > 11)
            {
                MessageBox.Show("Phone number must be between 7 and 11 digits.");
                return;
            }

            // find branch ID from bank and branch name
            int? branchId = bankService.GetBranchId(bankName, bankBranch);
            if (branchId == null)
            {
                MessageBox.Show("Specified bank or branch not found.");
                return;
            }

            try
            {
                using (var conn = DatabaseManager.Instance.GetConnection())
                {
                    conn.Open(); // open DB
                    var tx = conn.BeginTransaction(); // start a transaction

                    // update customer
                    customerService.UpdateCustomer(
                        customerId,
                        txtFirstName.Text.Trim(),
                        txtLastName.Text.Trim(),
                        txtEmail.Text.Trim(),
                        txtAddress.Text.Trim(),
                        txtPhone.Text.Trim(),
                        txtCardNumber.Text.Trim(),
                        txtPIN.Text.Trim(),
                        cmbCustomerStatus.SelectedItem?.ToString() ?? "Active",
                        txtCustomerUsername.Text.Trim(),
                        txtCustomerPassword.Text.Trim(),
                        conn,
                        tx
                    );

                    // update account
                    accountService.UpdateAccount(
                        customerId,
                        cmbAccountType.SelectedItem?.ToString() ?? "Savings",
                        Convert.ToDecimal(txtBalance.Text.Trim()),
                        cmbAccountStatus.SelectedItem?.ToString() ?? "Active",
                        branchId.Value,
                        conn,
                        tx
                    );

                    tx.Commit(); // finish the transaction
                    MessageBox.Show("Details updated successfully.");
                    this.Close(); // close form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message); // show error
            }
        }

        // close form if Cancel button clicked
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // this only allows letters for first/last name
        private void OnlyAllowLetters(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // only digits allowed (like balance)
        private void OnlyAllowNumbers(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // allows only digits and max length for things like card number
        private void LimitDigits(object? sender, KeyPressEventArgs e, int maxLength)
        {
            TextBox textBox = (TextBox)sender!;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && textBox.Text.Length >= maxLength)
            {
                e.Handled = true;
            }
        }

        // these are empty label click events that we didn’t use (auto-generated sometimes)
        private void label10_Click(object sender, EventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }
        private void label20_Click(object sender, EventArgs e) { }
    }
}
