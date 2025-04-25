using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE5201BankingSystemHE20882
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string cardNumber = txtCardNumber.Text.Trim();
            string pin = txtPin.Text.Trim();
            string status = cmbStatus.Text.Trim();

            if (firstName == "" || lastName == "" || email == "" || pin == "")
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            string connectionString = "Server=localhost;Database=BankingDB;Trusted_Connection=True;";
            string query = "INSERT INTO Customers (FirstName, LastName, Email, Address, PhoneNumber, CardNumber, Pin, Status) " +
                           "VALUES (@FirstName, @LastName, @Email, @Address, @Phone, @Card, @Pin, @Status)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Card", cardNumber);
                    cmd.Parameters.AddWithValue("@Pin", pin);
                    cmd.Parameters.AddWithValue("@Status", status);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Customer added successfully!");
                        this.Close(); // closes the AddCustomerForm
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // closes the AddCustomerForm
        }
    }
}
