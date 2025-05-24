using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWE5201BankingSystemHE20882.Services;
using System;

namespace SWE5201BankingSystemHE20882.Tests
{
    [TestClass]
    public class AccountServiceTests
    {
        // Made nullable to prevent CS8618 warning
        private AccountService? accountService;

        // This runs before each test method
        [TestInitialize]
        public void Setup()
        {
            accountService = new AccountService();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetAccountByCustomerId_InvalidId_ThrowsException()
        {
            // Arrange
            int invalidCustomerId = -1;

            // Act
            accountService!.GetAccountByCustomerId(invalidCustomerId); // Use null-forgiving operator since it's guaranteed non-null after Setup
        }

        [TestMethod]
        public void GetAccountId_NonExistentAccount_ReturnsMinusOne()
        {
            // Arrange
            int fakeCustomerId = -999;
            string accountType = "Savings";

            // Act
            int result = accountService!.GetAccountId(fakeCustomerId, accountType);

            // Assert
            Assert.AreEqual(-1, result);
        }
    }
}
