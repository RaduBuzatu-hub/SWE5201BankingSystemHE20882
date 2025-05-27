using System;                // we use this for basic things like DateTime and Console stuff
using System.Data;           // this let us use DataTable to hold data
using Microsoft.Data.SqlClient; // we use this to talk to SQL database

namespace SWE5201BankingSystemHE20882.Services
{
    // this is like a blueprint for a custom message we want to use later for alert or log
    public delegate void TransactionEventHandler(string message, DateTime timestamp);

    // this class is all about handling transactions like deposit and withdraw
    public class TransactionService
    {
        // this is like a signal we can use to tell other parts that something happened
        public event TransactionEventHandler OnTransactionRecorded = delegate { }; // we give it empty start to avoid null error

        // this function adds a new transaction and updates balance in account
        public bool RecordTransaction(int accountId, string type, decimal amount, DateTime timestamp)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection()) // connect to our database
            {
                conn.Open(); // open the connection so we can use it

                decimal preBalance = 0; // we store the old balance here

                // Step 1: Get the current balance from the Accounts table
                using (SqlCommand getBal = new SqlCommand("SELECT Balance FROM Accounts WHERE AccountID = @AccountID", conn))
                {
                    getBal.Parameters.AddWithValue("@AccountID", accountId); // give it the id to find right account
                    object result = getBal.ExecuteScalar(); // this gets one value only
                    if (result != null)
                        preBalance = Convert.ToDecimal(result); // if it find something we save it
                }

                // Step 2: Work out new balance by adding or subtracting
                decimal postBalance = (type.Equals("Deposit", StringComparison.OrdinalIgnoreCase))
                    ? preBalance + amount // if deposit we add
                    : preBalance - amount; // if not then must be withdraw so we minus

                // Step 3: Update the account with the new balance
                using (SqlCommand update = new SqlCommand("UPDATE Accounts SET Balance = @NewBalance WHERE AccountID = @AccountID", conn))
                {
                    update.Parameters.AddWithValue("@NewBalance", postBalance);
                    update.Parameters.AddWithValue("@AccountID", accountId);
                    update.ExecuteNonQuery(); // run it to save to database
                }

                // Step 4: Add a record to Transactions table so we remember what happened
                using (SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Transactions (AccountID, Amount, TransactionType, TransactionDate, PreBalance, PostBalance, ReceiptPrinted)
                    VALUES (@AccountID, @Amount, @TransactionType, @TransactionDate, @PreBalance, @PostBalance, @ReceiptPrinted)", conn))
                {
                    cmd.Parameters.AddWithValue("@AccountID", accountId); // fill all the values for transaction
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@TransactionType", type);
                    cmd.Parameters.AddWithValue("@TransactionDate", timestamp);
                    cmd.Parameters.AddWithValue("@PreBalance", preBalance);
                    cmd.Parameters.AddWithValue("@PostBalance", postBalance);
                    cmd.Parameters.AddWithValue("@ReceiptPrinted", false); // not printing in this case
                    cmd.ExecuteNonQuery(); // run it to save to table
                }

                // Step 5: Let other parts know transaction is done
                OnTransactionRecorded.Invoke($"{type} of £{amount}", timestamp); // show message if someone is listening

                return true; // say everything was ok
            }
        }

        // this gets all the transactions for a specific customer and their account type
        public DataTable GetTransactions(int customerId, string accountType)
        {
            DataTable dt = new DataTable(); // we make empty table to put results in

            using (SqlConnection conn = DatabaseManager.Instance.GetConnection()) // get connection
            {
                string query = @"
                    SELECT TransactionType, Amount, TransactionDate, PreBalance, PostBalance, ReceiptPrinted
                    FROM Transactions
                    WHERE AccountID = (
                        SELECT TOP 1 AccountID FROM Accounts
                        WHERE CustomerID = @CustomerID AND AccountType = @AccountType
                    )";

                SqlCommand cmd = new SqlCommand(query, conn); // setup command with SQL
                cmd.Parameters.AddWithValue("@CustomerID", customerId); // give customer ID
                cmd.Parameters.AddWithValue("@AccountType", accountType); // and account type

                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // adapter helps us fill table
                adapter.Fill(dt); // get the data from query into dt
            }

            return dt; // return the data table with results
        }
    }
}
