// these lines help us use database and system stuff
using System; // basic things like exceptions and data types
using System.Data; // lets us use datatable and adapters
using Microsoft.Data.SqlClient; // we need this to connect to SQL Server

// we are making this class inside the Services folder/namespace
namespace SWE5201BankingSystemHE20882.Services
{
    // this class is for doing all the work with banks and their branches
    public class BankService
    {
        // this method gets all banks and their branches from the database
        public DataTable GetAllBranchesWithBanks()
        {
            // opens the database connection
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                // SQL query that gets data from both bank and branch tables
                string query = @"
                    SELECT b.BankID, b.BankName, bb.BranchID, bb.BankBranch
                    FROM Bank b
                    JOIN BankBranches bb ON b.BankID = bb.BankID";

                // use adapter to run the query and put the data in a table
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable(); // create empty table
                adapter.Fill(dt); // fill table with data from SQL
                return dt; // return that table back
            }
        }

        // this method adds a bank and also a branch if needed
        public string AddBankAndBranch(string bankName, string branchName)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                conn.Open(); // start connection to SQL
                SqlTransaction tx = conn.BeginTransaction(); // start a transaction so all changes happen together

                try
                {
                    int bankId;

                    // we check if the bank is already in the system
                    string checkBank = "SELECT BankID FROM Bank WHERE BankName = @BankName";
                    using (SqlCommand checkCmd = new SqlCommand(checkBank, conn, tx))
                    {
                        checkCmd.Parameters.AddWithValue("@BankName", bankName);
                        object result = checkCmd.ExecuteScalar(); // get result from SQL

                        if (result != null)
                        {
                            bankId = (int)result; // bank found so use that ID
                        }
                        else
                        {
                            // bank not found so we insert new bank
                            string insertBank = "INSERT INTO Bank (BankName) OUTPUT INSERTED.BankID VALUES (@BankName)";
                            using (SqlCommand insertCmd = new SqlCommand(insertBank, conn, tx))
                            {
                                insertCmd.Parameters.AddWithValue("@BankName", bankName);
                                bankId = (int)insertCmd.ExecuteScalar(); // get new ID after insert
                            }
                        }
                    }

                    // check if branch already exists for this bank
                    string checkBranch = "SELECT COUNT(*) FROM BankBranches WHERE BankID = @BankID AND BankBranch = @Branch";
                    using (SqlCommand checkBranchCmd = new SqlCommand(checkBranch, conn, tx))
                    {
                        checkBranchCmd.Parameters.AddWithValue("@BankID", bankId);
                        checkBranchCmd.Parameters.AddWithValue("@Branch", branchName);
                        int exists = (int)checkBranchCmd.ExecuteScalar();

                        if (exists > 0)
                        {
                            tx.Rollback(); // cancel the transaction
                            return "Branch already exists for this bank.";
                        }
                    }

                    // add new branch now since it's not already there
                    string insertBranch = "INSERT INTO BankBranches (BankID, BankBranch) VALUES (@BankID, @Branch)";
                    using (SqlCommand insertBranchCmd = new SqlCommand(insertBranch, conn, tx))
                    {
                        insertBranchCmd.Parameters.AddWithValue("@BankID", bankId);
                        insertBranchCmd.Parameters.AddWithValue("@Branch", branchName);
                        insertBranchCmd.ExecuteNonQuery();
                    }

                    tx.Commit(); // save everything if no errors
                    return "Bank and branch added successfully.";
                }
                catch (Exception ex)
                {
                    tx.Rollback(); // undo all if something breaks
                    return "Error adding bank and branch: " + ex.Message;
                }
            }
        }

        // this deletes the bank and all its branches (full removal)
        public string DeleteBankWithBranches(int bankId)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                conn.Open();
                SqlTransaction tx = conn.BeginTransaction(); // group delete steps together

                try
                {
                    // first delete the branches linked to the bank
                    string deleteBranches = "DELETE FROM BankBranches WHERE BankID = @BankID";
                    using (SqlCommand branchCmd = new SqlCommand(deleteBranches, conn, tx))
                    {
                        branchCmd.Parameters.AddWithValue("@BankID", bankId);
                        branchCmd.ExecuteNonQuery();
                    }

                    // then delete the bank itself
                    string deleteBank = "DELETE FROM Bank WHERE BankID = @BankID";
                    using (SqlCommand bankCmd = new SqlCommand(deleteBank, conn, tx))
                    {
                        bankCmd.Parameters.AddWithValue("@BankID", bankId);
                        bankCmd.ExecuteNonQuery();
                    }

                    tx.Commit(); // save changes
                    return "Bank and all its branches deleted successfully.";
                }
                catch (Exception ex)
                {
                    tx.Rollback(); // undo if problem
                    return "Error deleting bank: " + ex.Message;
                }
            }
        }

        // this deletes just one branch (not whole bank)
        public string DeleteBranch(int branchId)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                string delete = "DELETE FROM BankBranches WHERE BranchID = @BranchID";
                using (SqlCommand cmd = new SqlCommand(delete, conn))
                {
                    cmd.Parameters.AddWithValue("@BranchID", branchId);
                    conn.Open(); // open connection
                    int rows = cmd.ExecuteNonQuery(); // run the delete
                    return rows > 0 ? "Branch deleted successfully." : "Branch not found.";
                }
            }
        }

        // this gets the ID of a branch if we know the bank and branch names
        public int? GetBranchId(string bankName, string bankBranch)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                string query = @"
                    SELECT bb.BranchID 
                    FROM BankBranches bb
                    JOIN Bank b ON bb.BankID = b.BankID
                    WHERE b.BankName = @BankName AND bb.BankBranch = @Branch";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BankName", bankName);
                cmd.Parameters.AddWithValue("@Branch", bankBranch);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : (int?)null; // return result or null if not found
            }
        }

        // this finds the bank ID if we just give the bank name
        public int? GetBankIdByName(string bankName)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                string query = "SELECT BankID FROM Bank WHERE BankName = @BankName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BankName", bankName);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : (int?)null;
            }
        }

        // this gets the actual bank and branch names if we give their IDs
        public Tuple<string, string>? GetBankAndBranchName(int bankId, int branchId)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                string query = @"
                    SELECT b.BankName, bb.BankBranch
                    FROM Bank b
                    JOIN BankBranches bb ON b.BankID = bb.BankID
                    WHERE b.BankID = @BankID AND bb.BranchID = @BranchID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BankID", bankId);
                cmd.Parameters.AddWithValue("@BranchID", branchId);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string bankName = reader["BankName"].ToString() ?? "";
                        string branchName = reader["BankBranch"].ToString() ?? "";
                        return Tuple.Create(bankName, branchName); // send back both names
                    }
                }

                return null; // if not found
            }
        }

        // this gives a list of all banks and branches, useful for admin pages
        public DataTable GetBankAndBranchList()
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                string query = @"
                    SELECT b.BankID, b.BankName, bb.BankBranch
                    FROM Bank b
                    JOIN BankBranches bb ON b.BankID = bb.BankID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable(); // make empty table
                adapter.Fill(dt); // fill with data
                return dt; // return table to show in app
            }
        }
    }
}
