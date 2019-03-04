using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources
{
    public class Database
    {
        private readonly string _host = "sysa14.database.windows.net";
        private readonly string _dbName = "SYSA14";
        private readonly string _username = "jdbc_admin";
        private readonly string _password = "0B[2blTpc}gd";
        private SqlConnection connection = null;

        // Public Fields
        public SqlConnection Connection { get => connection; }

        public Database()
        {
            CreateConnection();
        }

        private void CreateConnection()
        {
            Console.WriteLine("Create connection..");
            // Create and set connection
            try
            {
                connection = new SqlConnection(GetConnectionString());
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
        }

        private string GetConnectionString()
        {
            string connectionString = String.Format(
                "Server=tcp:{0},1433; Initial Catalog={1}; Persist Security Info=False; " +
                "User ID={2};Password={3}; MultipleActiveResultSets=False; Encrypt=True; " +
                "TrustServerCertificate=True; Connection Timeout=30;",
                _host, _dbName, _username, _password
            );

            return connectionString;
        }

        public bool IsConnect(SqlConnection connection)
        {
            return connection != null;
        }

        public void CloseConnection(SqlConnection conn)
        {
            conn.Close();
        }

    }
}
