using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Resources;

namespace PK2_Client
{
    class Database
    {
        private static readonly string _host = "uwdb18.srv.lu.se";
        private static readonly string _instanceName = "icssql001";
        private static readonly string _dbName = "SYSA14_PK_ProgAssignment2";
        private static readonly string _username = "sysa14reader";
        private static readonly string _password = "INFreader1";

        // Public Fields
        public SqlConnection Connection { get; set; }

        public Database()
        {
            CreateConnection();
        }

        // Create and set connection    
        private void CreateConnection()
        {
            try
            {
                Connection = new SqlConnection(GetConnectionString());
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
        }

        private string GetConnectionString()
        {
            string connectionString = String.Format(
                "Data Source={0}\\{1}; Initial Catalog={2}; User id={3}; Password={4};",
                _host, _instanceName, _dbName, _username, _password
            );

            return connectionString;
        }

        public void CloseConnection(SqlConnection conn)
        {
            conn.Close();
        }

    }
}