using System;                         // this gives us basic stuff like string and int
using System.Windows.Forms;           // this helps us make buttons, textboxes and forms
using SWE5201BankingSystemHE20882.Services; // this brings in the AuthService class for logging in

namespace SWE5201BankingSystemHE20882
{
    // this is the login screen for both admin people (staff) and customers
    public partial class Log_In : Form
    {
        // we make the auth service object to check username and password
        private readonly AuthService _authService = new AuthService();

        // this sets up the form when it loads
        public Log_In()
        {
            InitializeComponent(); // this draws the form with all controls
        }

        // this is for when staff clicks login
        private void btnBankStaffLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim(); // get rid of spaces before and after
            string password = txtPassword.Text.Trim(); // get the password from textbox

            // check if the details are correct using the auth service
            if (_authService.ValidateBankStaff(username, password))
            {
                MessageBox.Show("Login successful!", "Success"); // show happy message

                this.Hide(); // hide this login window

                using (MainForm dashboard = new MainForm()) // make new dashboard for staff
                {
                    dashboard.WindowState = FormWindowState.Maximized; // make it big screen
                    dashboard.ShowDialog(); // open it as a modal window (they can't go back)
                }

                this.Close(); // after dashboard closes, this login form also closes
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Login Failed"); // show error if wrong
            }
        }

        // this one runs if customer tries to login
        private void btnCustomerLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim(); // get the username
            string password = txtPassword.Text.Trim(); // get the password

            // if username or password box is empty, tell them to enter it
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Invalid credentials.", "Login Failed");
                return;
            }

            try
            {
                // ask auth service to get the customer's ID if login is right
                int? customerId = _authService.ValidateCustomer(username, password);

                if (customerId != null) // if we get a customer ID back, that means login worked
                {
                    MessageBox.Show("Login successful!", "Success"); // say login worked
                    CustomerDashboardForm dashboard = new CustomerDashboardForm(customerId.Value); // make the dashboard and give it customer ID
                    dashboard.WindowState = FormWindowState.Maximized; // make it full screen
                    dashboard.Show(); // show the dashboard
                    this.Hide();      // hide this login screen
                }
                else
                {
                    MessageBox.Show("Invalid credentials.", "Login Failed"); // login failed
                }
            }
            catch (Exception ex) // in case some error happens (like db not working)
            {
                MessageBox.Show("Error: " + ex.Message, "Login Error"); // show the error
            }
        }

        // these are auto-made functions when we click labels or other controls by accident
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void Log_In_Load(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click_2(object sender, EventArgs e) { }
        private void lblPassword_Click(object sender, EventArgs e) { }
    }
}
