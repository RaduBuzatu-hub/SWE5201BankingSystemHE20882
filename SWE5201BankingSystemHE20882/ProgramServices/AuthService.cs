// we use this to work with basic system functions like strings
using System;
// we use this one to connect and talk to our SQL database
using Microsoft.Data.SqlClient;

// this is the namespace like a folder where all the services go
namespace SWE5201BankingSystemHE20882.Services
{
    // this class checks if user login info is correct for both staff and customer
    public class AuthService
    {
        // this one checks if the bank staff username and password is correct
        public bool ValidateBankStaff(string username, string password)
        {
            // open connection to the database using singleton thingy
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                // this SQL says count how many rows match the username and password
                string query = "SELECT COUNT(*) FROM BankStaff WHERE Username = @username AND Password = @password";

                // we make command to send the sql and connect it to the database
                SqlCommand cmd = new SqlCommand(query, conn);

                // give the actual username and password to the query safely
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                // open the connection so we can talk to the database
                conn.Open();

                // run the command and get how many match (0 means none, 1 means found)
                int result = (int)cmd.ExecuteScalar();

                // if result is more than 0, it means login works
                return result > 0;
            }
        }
        // this one checks if customer username and password is good
        // if it's good, it gives back their customer ID
        public int? ValidateCustomer(string username, string password)
        {
            // open the database
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                // SQL to find customer ID that matches username and password
                string query = "SELECT CustomerID FROM Customers WHERE CustomerUsername = @username AND CustomerPassword = @password";

                // set up the command and give the values
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                // open connection so we can run it
                conn.Open();

                // run and check if it found something
                object result = cmd.ExecuteScalar();

                // if something found, return it as int, else return null
                return result != null ? Convert.ToInt32(result) : (int?)null;
            }
        }
    }
}
