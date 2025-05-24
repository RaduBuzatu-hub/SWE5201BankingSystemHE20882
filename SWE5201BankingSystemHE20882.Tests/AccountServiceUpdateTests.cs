using SWE5201BankingSystemHE20882.Services;
using Microsoft.Data.SqlClient;

[TestClass]
public class AccountServiceUpdateTests
{
    private AccountService? accountService;
    private int testCustomerId = 2013; // Use the real CustomerID
    private string accountType = "Savings"; // Account that exists

    [TestInitialize]
    public void Setup()
    {
        accountService = new AccountService();
    }

    [TestMethod]
    public void UpdateAccount_ChangesBalanceCorrectly()
    {
        decimal newBalance = 200.00m;
        string newStatus = "Active";
        int branchId = 11; // Match the existing branch

        using (var conn = DatabaseManager.Instance.GetConnection())
        {
            conn.Open();
            var transaction = conn.BeginTransaction();

            // Act: Perform update
            accountService!.UpdateAccount(
                testCustomerId,
                accountType,
                newBalance,
                newStatus,
                branchId,
                conn,
                transaction
            );

            transaction.Commit(); // Apply changes
        }

        // Assert: Read back updated balance
        using (var conn = DatabaseManager.Instance.GetConnection())
        {
            conn.Open();
            string query = "SELECT Balance FROM Accounts WHERE CustomerID = @CustomerID AND AccountType = @AccountType";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CustomerID", testCustomerId);
            cmd.Parameters.AddWithValue("@AccountType", accountType);

            object result = cmd.ExecuteScalar();
            decimal actualBalance = Convert.ToDecimal(result);

            Assert.AreEqual(newBalance, actualBalance);
        }
    }
}
