// we use these for working with databases and sql 
using System; // this gives us basic stuff like variables, numbers, and exceptions
using System.Data; // this helps us use tables and rows for database
using Microsoft.Data.SqlClient; // this lets us talk to SQL database

namespace SWE5201BankingSystemHE20882.Services // our folder name for services
{
    // this class is for account stuff like making, updating or getting account
    public class AccountService
    {
        // this method finds account using the customer's ID
        public DataRow GetAccountByCustomerId(int customerId)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection()) // open connection to database
            {
                string query = "SELECT TOP 1 * FROM Accounts WHERE CustomerID = @CustomerID"; // get first account for that customer
                SqlCommand cmd = new SqlCommand(query, conn); // make command using the query and connection
                cmd.Parameters.AddWithValue("@CustomerID", customerId); // give it the customer ID value

                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // this helps to fill data into a table
                DataTable dt = new DataTable(); // create new empty table
                adapter.Fill(dt); // fill table with the results from the query

                // if nothing found we give error
                if (dt.Rows.Count == 0)
                {
                    throw new InvalidOperationException("No account found for the specified CustomerID."); // throw message if no account
                }

                return dt.Rows[0]; // return first row
            }
        }

        // gets account ID by customer ID and type of account (like Savings)
        public int GetAccountId(int customerId, string accountType)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection()) // open connection
            {
                string query = "SELECT TOP 1 AccountID FROM Accounts WHERE CustomerID = @CustomerID AND AccountType = @AccountType"; // SQL to find it
                SqlCommand cmd = new SqlCommand(query, conn); // make command
                cmd.Parameters.AddWithValue("@CustomerID", customerId); // give customer ID
                cmd.Parameters.AddWithValue("@AccountType", accountType); // give account type

                conn.Open(); // open database
                object result = cmd.ExecuteScalar(); // get just one value
                return result != null ? Convert.ToInt32(result) : -1; // if found return the ID, if not return -1
            }
        }

        // this update account details like money and status. it uses a transaction too
        public void UpdateAccount(int customerId, string accountType, decimal balance, string status, int branchID, SqlConnection conn, SqlTransaction tx)
        {
            SqlCommand cmd = new SqlCommand(@"
        UPDATE Accounts 
        SET AccountType = @AccountType, 
            Balance = @Balance,
            Status = @Status, 
            BranchID = @BranchID 
        WHERE CustomerID = @CustomerID AND AccountType = @AccountType", conn, tx); // SQL to change account info

            cmd.Parameters.AddWithValue("@AccountType", accountType); // add values to the SQL
            cmd.Parameters.AddWithValue("@Balance", balance);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@BranchID", branchID);
            cmd.Parameters.AddWithValue("@CustomerID", customerId);

            int affected = cmd.ExecuteNonQuery(); // run the command and check how many rows changed
            if (affected == 0)
            {
                throw new Exception("UpdateAccount failed: No rows affected. Check if CustomerID and AccountType are valid."); // show error if nothing updated
            }
        }

        // makes a new account for a person using info from the form
        public bool CreateAccount(int customerId, string accountType, decimal balance, int bankId, int branchId, string status)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection()) // open connection
            {
                string query = @"
                    INSERT INTO Accounts 
                    (CustomerID, AccountType, Balance, CreatedAt, BankID, BranchID, Status)
                    VALUES 
                    (@CustomerID, @AccountType, @Balance, GETDATE(), @BankID, @BranchID, @Status)"; // SQL to add new account

                SqlCommand cmd = new SqlCommand(query, conn); // make command for insert

                cmd.Parameters.AddWithValue("@CustomerID", customerId); // set the values for account
                cmd.Parameters.AddWithValue("@AccountType", accountType);
                cmd.Parameters.AddWithValue("@Balance", balance);
                cmd.Parameters.AddWithValue("@BankID", bankId);
                cmd.Parameters.AddWithValue("@BranchID", branchId);
                cmd.Parameters.AddWithValue("@Status", status);

                conn.Open(); // open database
                return cmd.ExecuteNonQuery() > 0; // if row was added then return true
            }
        }

        // gets all accounts and show also the bank name and branch
        public DataTable GetAllAccountsWithBranches()
        {
            DataTable dt = new DataTable(); // empty table

            using (SqlConnection conn = DatabaseManager.Instance.GetConnection()) // connect to DB
            {
                string query = @"
                    SELECT a.AccountID, a.CustomerID, a.AccountType, a.Balance, a.Status,
                           bb.BankBranch, b.BankName
                    FROM Accounts a
                    JOIN BankBranches bb ON a.BranchID = bb.BranchID
                    JOIN Bank b ON bb.BankID = b.BankID"; // join with branch and bank

                SqlCommand cmd = new SqlCommand(query, conn); // make the command
                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // adapter fills the table
                adapter.Fill(dt); // fill it
            }

            return dt; // return the table
        }

        // this method deletes account using the account ID
        public string DeleteAccount(int accountId)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection()) // open DB
            {
                string query = "DELETE FROM Accounts WHERE AccountID = @AccountID"; // SQL to delete by ID
                SqlCommand cmd = new SqlCommand(query, conn); // make command
                cmd.Parameters.AddWithValue("@AccountID", accountId); // add the account ID

                conn.Open(); // open connection
                int rows = cmd.ExecuteNonQuery(); // run and get how many rows got deleted

                return rows > 0 ? "Account deleted successfully." : "Account not found."; // return message
            }
        }
    }
}
