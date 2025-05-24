using System;  // this is for basic stuff like string and events
using System.Windows.Forms;  // this lets us make windows and buttons and textboxes
using SWE5201BankingSystemHE20882.Services;  // we use this to get the ATMService to save data

namespace SWE5201BankingSystemHE20882
{
    // this is the form where admin can add a new ATM machine
    public partial class AddATMForm : Form
    {
        // we create the atm service so we can use it to add new atm to the database
        private readonly ATMService _atmService = new ATMService();

        // this runs when we open the form and it shows the UI
        public AddATMForm()
        {
            InitializeComponent(); // this line loads all the controls like textbox, buttons etc
        }

        // this runs when we click the Add ATM button
        private void btnAddATM_Click(object sender, EventArgs e)
        {
            // we get the values from textbox and dropdown
            string location = txtLocation.Text.Trim(); // get location from input
            string? selectedCardType = cmbCardType.SelectedItem?.ToString(); // get card type from combo box

            if (string.IsNullOrWhiteSpace(selectedCardType)) // if card type not selected
            {
                MessageBox.Show("Please select a card type."); // tell user to pick card type
                return;
            }

            string cardType = selectedCardType; // assign to variable
            string cashText = txtCashAvailable.Text.Trim(); // get cash input
            string bankIdText = txtBankID.Text.Trim(); // get bank ID input
            string branchIdText = txtBranchID.Text.Trim(); // get branch ID input

            // check if any field is empty
            if (string.IsNullOrWhiteSpace(location) || string.IsNullOrWhiteSpace(cardType) ||
                string.IsNullOrWhiteSpace(cashText) || string.IsNullOrWhiteSpace(bankIdText) || string.IsNullOrWhiteSpace(branchIdText))
            {
                MessageBox.Show("Please fill in all fields."); // tell user to fill everything
                return;
            }

            // now try to convert cash, bank id and branch id to numbers
            if (!decimal.TryParse(cashText, out decimal cashAvailable) ||
                !int.TryParse(bankIdText, out int bankId) ||
                !int.TryParse(branchIdText, out int branchId))
            {
                MessageBox.Show("Cash, Bank ID, and Branch ID must be valid numbers."); // show error if not numbers
                return;
            }

            // call the service to add the new ATM
            bool success = _atmService.AddATM(location, cardType, cashAvailable, bankId, branchId);

            if (success)
            {
                MessageBox.Show("ATM added successfully!"); // if success, show message
                this.Close(); // and close the form
            }
            else
            {
                MessageBox.Show("Failed to add ATM. Please try again."); // if not work show error
            }
        }

        // this is for Cancel button, just closes the window
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // close form
        }

        // this is not used much, it’s just there from the UI design maybe
        private void label2_Click(object sender, EventArgs e) { }
    }
}
