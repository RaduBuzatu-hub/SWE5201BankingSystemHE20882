// we use these to connect to database and do sql stuff
using System;
using System.Data;
using Microsoft.Data.SqlClient; // this one helps us use SQL with C#

// this is our namespace, kind of like a folder or project name
namespace SWE5201BankingSystemHE20882.Services
{
    // this class is for doing ATM stuff like adding, deleting, or showing atm info
    public class ATMService
    {
        // this method add new atm in database
        public bool AddATM(string location, string cardType, decimal cashAvailable, int bankId, int branchId)
        {
            // we open the database connection using the shared DatabaseManager
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                // this is the SQL command to insert atm info
                string query = @"
                    INSERT INTO ATM (Location, AcceptedCardType, CashAvailable, BankID, BranchID)
                    VALUES (@Location, @CardType, @CashAvailable, @BankID, @BranchID)";

                // now we make the command with the query and connection
                SqlCommand cmd = new SqlCommand(query, conn);

                // we give the values to the query so it knows what to insert
                cmd.Parameters.AddWithValue("@Location", location);           // where the atm is placed
                cmd.Parameters.AddWithValue("@CardType", cardType);           // like Visa, MasterCard
                cmd.Parameters.AddWithValue("@CashAvailable", cashAvailable); // how much money it got
                cmd.Parameters.AddWithValue("@BankID", bankId);               // which bank it belongs to
                cmd.Parameters.AddWithValue("@BranchID", branchId);           // which branch of the bank

                conn.Open(); // open the database
                return cmd.ExecuteNonQuery() > 0; // this runs it, return true if atm added
            }
        }

        // this shows all atm and tells what bank and branch they are from
        public DataTable GetAllATMsWithBankBranch()
        {
            DataTable dt = new DataTable(); // make empty table

            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                // sql to get atm info plus bank name and branch
                string query = @"
                    SELECT a.ATMID, a.Location, a.AcceptedCardType, a.CashAvailable,
                           bb.BankBranch, b.BankName
                    FROM ATM a
                    JOIN BankBranches bb ON a.BranchID = bb.BranchID
                    JOIN Bank b ON bb.BankID = b.BankID";

                SqlCommand cmd = new SqlCommand(query, conn); // create sql command
                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // adapter fills the data
                adapter.Fill(dt); // put data in the table
            }

            return dt; // return the table with atm details
        }

        // this one deletes atm by using atm id
        public string DeleteATM(int atmId)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                string query = "DELETE FROM ATM WHERE ATMID = @ATMID"; // sql to delete one atm

                SqlCommand cmd = new SqlCommand(query, conn); // make the command
                cmd.Parameters.AddWithValue("@ATMID", atmId); // put the id in the query

                conn.Open(); // open the database
                int rows = cmd.ExecuteNonQuery(); // run the delete

                // if atm got deleted we say so, if not we say it wasn’t there
                return rows > 0 ? "ATM deleted successfully." : "ATM not found or already deleted.";
            }
        }

        // this shows all transactions that used the atm
        public DataTable GetATMTransactions(int atmId)
        {
            DataTable dt = new DataTable(); // make new empty table

            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                // sql joins transaction with account and customer to show full info
                string query = @"
                    SELECT t.TransactionID, t.TransactionType, t.Amount, t.TransactionDate, 
                           c.FirstName + ' ' + c.LastName AS CustomerName
                    FROM Transactions t
                    JOIN Accounts a ON t.AccountID = a.AccountID
                    JOIN Customers c ON a.CustomerID = c.CustomerID
                    WHERE t.ATMID = @ATMID"; // filter only the atm we want

                SqlCommand cmd = new SqlCommand(query, conn); // make command
                cmd.Parameters.AddWithValue("@ATMID", atmId); // give it the atm id

                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // adapter to fill data
                adapter.Fill(dt); // fill data into table
            }

            return dt; // return the table with transactions
        }
    }
}
