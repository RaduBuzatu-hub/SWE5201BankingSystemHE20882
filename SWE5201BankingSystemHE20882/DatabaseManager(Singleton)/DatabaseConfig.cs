// This line means we are using some basic tools from C#
// like working with text and collections
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This is our own namespace where we keep all service files for the banking app
namespace SWE5201BankingSystemHE20882.Services
{
    // This class is static, means we can't make a object from it, 
    // but we can still use it to keep settings for our database connection
    public static class DatabaseConfig
    {
        // This line makes a variable that hold the connection string for the database.
        // it use 'readonly' so the string can’t be changed once program start
        // Connection string tells program where the database is and how to connect to it
        public static readonly string ConnectionString =
            "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BankingDB;Integrated Security=True;TrustServerCertificate=True;";
    }
}