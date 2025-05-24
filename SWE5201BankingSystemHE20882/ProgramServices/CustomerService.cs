// we using this to work with basic stuff in c#
using System;
// not used in this file but can help when returning list of customers later
using System.Collections.Generic;
// this one let us use DataTable and work with tables from database
using System.Data;
// we use this to connect to SQL server and run commands
using Microsoft.Data.SqlClient;

// we put this class inside our banking system service folder
namespace SWE5201BankingSystemHE20882.Services
{
    // this class is for all customer stuff like add, update, delete, get data etc
    public class CustomerService
    {
        // method for getting all customers from database
        public DataTable GetAllCustomers()
        {
            DataTable dt = new DataTable(); // we make empty table
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection()) // get connection from our database manager
            {
                string query = "SELECT * FROM Customers"; // sql to get all customers
                using (SqlCommand cmd = new SqlCommand(query, conn)) // make command with query and connection
                {
                    conn.Open(); // open the connection
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); // adapter fills data
                    adapter.Fill(dt); // now dt has all the data
                }
            }
            return dt; // send the table back
        }

        // this one updates customer status like Active or Inactive
        public void UpdateCustomerStatus(int customerId, string status)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                string query = "UPDATE Customers SET Status = @status WHERE CustomerID = @customerId"; // sql to update
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", status); // give values
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    conn.Open(); // open connection
                    cmd.ExecuteNonQuery(); // run the update
                }
            }
        }

        // this one add new customer to our database
        public bool AddCustomer(string firstName, string lastName, string email, string address, string phone,
                                string cardNumber, string pin, string status, string username, string password)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                // insert new customer
                string query = @"INSERT INTO Customers 
                         (FirstName, LastName, Email, Address, PhoneNumber, CardNumber, Pin, Status, CustomerUsername, CustomerPassword)
                         VALUES 
                         (@FirstName, @LastName, @Email, @Address, @Phone, @Card, @Pin, @Status, @Username, @Password)";

                SqlCommand cmd = new SqlCommand(query, conn);

                // fill the values into the insert
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Card", cardNumber);
                cmd.Parameters.AddWithValue("@Pin", pin);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                int rows = cmd.ExecuteNonQuery(); // run insert
                return rows > 0; // if insert success return true
            }
        }

        // get customer account info by ID and account type
        public DataRow? GetCustomerAccountDetails(int customerId, string accountType)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                string query = @"
            SELECT c.FirstName, c.LastName, c.Email,
                   a.Balance, a.AccountType, a.Status
            FROM Customers c
            JOIN Accounts a ON c.CustomerID = a.CustomerID
            WHERE c.CustomerID = @CustomerID AND a.AccountType = @AccountType";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    cmd.Parameters.AddWithValue("@AccountType", accountType);

                    conn.Open(); // open connection
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader); // read data into table

                        return dt.Rows.Count > 0 ? dt.Rows[0] : null; // if we got data return first row
                    }
                }
            }
        }

        // get customer by just ID
        public DataRow? GetCustomerById(int customerId)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                string query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt); // fill table with result

                return dt.Rows.Count > 0 ? dt.Rows[0] : null; // return row or null
            }
        }

        // update the customer info when we edit in modify screen
        public void UpdateCustomer(int customerId, string firstName, string lastName, string email, string address, string phone,
                                   string cardNumber, string pin, string status, string username, string password,
                                   SqlConnection conn, SqlTransaction tx)
        {
            // sql to update customer with new values
            SqlCommand cmd = new SqlCommand(@"
                UPDATE Customers SET 
                    FirstName = @FirstName, LastName = @LastName, Email = @Email, Address = @Address,
                    PhoneNumber = @Phone, CardNumber = @CardNumber, Pin = @PIN, Status = @Status,
                    CustomerUsername = @Username, CustomerPassword = @Password
                WHERE CustomerID = @CustomerID", conn, tx); // uses transaction

            // fill values to update
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@CardNumber", cardNumber);
            cmd.Parameters.AddWithValue("@PIN", pin);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@CustomerID", customerId);

            cmd.ExecuteNonQuery(); // run the update
        }

        // delete the customer and their inactive accounts
        public string DeleteCustomerAndInactiveAccounts(int customerId)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                conn.Open();
                SqlTransaction tx = conn.BeginTransaction(); // start transaction

                try
                {
                    // delete account only if inactive
                    string deleteAccounts = "DELETE FROM Accounts WHERE CustomerID = @CustomerID AND Status = 'Inactive'";
                    SqlCommand cmd1 = new SqlCommand(deleteAccounts, conn, tx);
                    cmd1.Parameters.AddWithValue("@CustomerID", customerId);
                    cmd1.ExecuteNonQuery();

                    // delete the customer after
                    string deleteCustomer = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                    SqlCommand cmd2 = new SqlCommand(deleteCustomer, conn, tx);
                    cmd2.Parameters.AddWithValue("@CustomerID", customerId);
                    int rows = cmd2.ExecuteNonQuery();

                    tx.Commit(); // save changes if no errors
                    return rows > 0 ? "Customer and inactive accounts deleted." : "Customer not found.";
                }
                catch (Exception ex)
                {
                    tx.Rollback(); // cancel changes if fail
                    return "Error deleting customer: " + ex.Message;
                }
            }
        }
    }
}
