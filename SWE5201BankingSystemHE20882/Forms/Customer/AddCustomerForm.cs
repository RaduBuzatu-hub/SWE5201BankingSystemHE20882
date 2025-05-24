using System; // we use this for basic stuff like strings and events
using System.Windows.Forms; // this is for showing the form and using buttons and textboxes
using SWE5201BankingSystemHE20882.Services; // we use this to talk to the CustomerService class

namespace SWE5201BankingSystemHE20882
{
    // this form is used to add new customer into the system by admin
    public partial class AddCustomerForm : Form
    {
        // we create an object from CustomerService to save the customer info
        private readonly CustomerService _customerService = new CustomerService();

        // this is the form constructor it runs first when form opens
        public AddCustomerForm()
        {
            InitializeComponent(); // this line loads all the UI controls like textbox and buttons

            // when typing name we only want letters, no numbers
            txtFirstName.KeyPress += OnlyAllowLetters;
            txtLastName.KeyPress += OnlyAllowLetters;

            // here we make sure that phone is max 11 digits, pin is 4 and card is 16 digits
            txtPhone.KeyPress += (s, e) => LimitDigits(s, e, 11);
            txtPin.KeyPress += (s, e) => LimitDigits(s, e, 4);
            txtCardNumber.KeyPress += (s, e) => LimitDigits(s, e, 16);
        }

        // this code runs when user clicks the save button
        private void btnSave_Click(object sender, EventArgs e)
        {
            // we take all text from the textboxes and remove any extra spaces
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string cardNumber = txtCardNumber.Text.Trim();
            string pin = txtPin.Text.Trim();
            string status = cmbStatus.Text.Trim();
            string username = txtCustomerUsername.Text.Trim();
            string password = txtCustomerPassword.Text.Trim();

            // check if important fields are empty
            if (firstName == "" || lastName == "" || email == "" || pin == "" || username == "" || password == "")
            {
                MessageBox.Show("Please fill in all required fields."); // show error if something missing
                return;
            }

            // pin must be 4 digits long
            if (pin.Length != 4)
            {
                MessageBox.Show("PIN must be exactly 4 digits.");
                return;
            }

            // card number must be 16 digits
            if (cardNumber.Length != 16)
            {
                MessageBox.Show("Card Number must be 16 digits.");
                return;
            }

            // phone must be between 7 to 11 digits
            if (phone.Length < 7 || phone.Length > 11)
            {
                MessageBox.Show("Phone number must be between 7 and 11 digits.");
                return;
            }

            // now we try to add the customer using the service
            bool success = _customerService.AddCustomer(
                firstName, lastName, email, address, phone,
                cardNumber, pin, status, username, password);

            // if success we show success message and close the form
            if (success)
            {
                MessageBox.Show("Customer added successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong."); // show error if adding failed
            }
        }

        // this runs when cancel button is clicked
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // just close the form
        }

        // this only allows letters and space, no numbers or symbols
        private void OnlyAllowLetters(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // stop wrong key from being typed
            }
        }

        // this allows only digits and also checks max length
        private void LimitDigits(object? sender, KeyPressEventArgs e, int maxLength)
        {
            TextBox textBox = (TextBox)sender!;

            // if not a number or backspace then don’t let user type it
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // if already max length, don’t let more typing
            if (!char.IsControl(e.KeyChar) && textBox.Text.Length >= maxLength)
            {
                e.Handled = true;
            }
        }

        // this was maybe made by designer, not used for now
        private void label11_Click(object sender, EventArgs e)
        {
            // nothing here
        }
    }
}
