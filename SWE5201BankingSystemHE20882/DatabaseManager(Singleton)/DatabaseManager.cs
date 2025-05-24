// we use this modern sql client to connect to the database properly
using Microsoft.Data.SqlClient;

namespace SWE5201BankingSystemHE20882.Services
{
    // this class helps us connect to the database safely
    // we use "sealed" so no one else can extend or inherit this class
    public sealed class DatabaseManager
    {
        // we make a static variable so there's only one of this class running (singleton pattern)
        private static readonly DatabaseManager instance = new DatabaseManager();

        // this variable stores the connection string from another class
        private readonly string _connectionString;

        // the constructor is private so nobody can make a new one from outside
        private DatabaseManager()
        {
            // we get the connection string from the DatabaseConfig class we made before
            _connectionString = DatabaseConfig.ConnectionString;
        }

        // this line lets other classes use the one and only instance of this class
        public static DatabaseManager Instance => instance;

        // this function creates and returns a connection to the database using the string above
        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
