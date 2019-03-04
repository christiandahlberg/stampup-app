using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Resources;

namespace PK2_Client
{
    public class TableReader
    {
        // Initilize attributes
        private SqlConnection connection;
        private Database db;

        // Initilize fields
        public string TableName { get; set; }
        public List<TableObject> TableObjects { get; set; }

        // Constructor
        public TableReader(string tableName)
        {
            this.db = new Database();
            this.connection = db.Connection;
            TableName = tableName;
            CreateTableObjects();
        }

        // Create instances of Table Object and adds to list
        public void CreateTableObjects()
        {
            // Initilize variables
            TableObjects = new List<TableObject>();

            // Create new TableObject for each table name
            foreach (string tableName in GetTableNames())
            {
                TableObjects.Add(new TableObject(tableName, GetNumberOfRows(tableName), GetColumnNames(tableName)));
            }
        }

        // Returns first column values (table names) of given table
        public List<string> GetTableNames()
        {
            // Initilize variables
            List<string> tableNames = new List<string>();

            try
            {
                // Open connection
                connection.Open();

                // Create command
                SqlCommand command = new SqlCommand(String.Format("SELECT * FROM {0}", TableName), connection);

                // Execute command
                SqlDataReader reader = command.ExecuteReader();

                // Loop through resultset
                while (reader.Read())
                {
                    string tableName = reader.GetString(0).ToString();
                    tableNames.Add(reader.GetString(0).ToString());
                }

                // Close reader
                reader.Close();
            }
            catch (SqlException e) { ExceptionHandler.HandleErrorException(e); }
            finally { db.CloseConnection(connection); }

            return tableNames;
        }

        // Returns number of rows in given table
        private int GetNumberOfRows(string tableName)
        {
            int numOfRows = 0;

            try
            {
                // Open connection
                connection.Open();

                // Create command
                SqlCommand command = new SqlCommand(
                    String.Format("SELECT COUNT(*) FROM {0}", tableName),
                    connection
                );

                // Execute command
                SqlDataReader reader = command.ExecuteReader();

                // Read value of first column
                reader.Read();
                numOfRows = reader.GetInt32(0);

                // Close reader
                reader.Close();
            }
            catch (SqlException e) { ExceptionHandler.HandleErrorException(e); }
            finally { db.CloseConnection(connection); }

            return numOfRows;
        }

        // Returns list of column names in given table
        private List<string> GetColumnNames(string tableName)
        {
            // Initilize variables
            DataTable columns = new DataTable();
            List<string> columnNames = new List<string>();

            string[] restrictionsColumns = new string[4];
            restrictionsColumns[2] = tableName;

            try
            {
                connection.Open();
                columns = connection.GetSchema("Columns", restrictionsColumns);
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally
            {
                db.CloseConnection(connection);
            }

            foreach (DataRow rowColumn in columns.Rows)
            {
                string columnName = rowColumn[3].ToString();
                columnNames.Add(columnName);
            }

            return columnNames;
        }

        public TableObject GetTableObjectByName(string tableName)
        {
            foreach (TableObject to in TableObjects)
            {
                if (to.TableName.Equals(tableName))
                {
                    return to;
                }
            }

            return null;
        }
    }
}