using Resources.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources.DAL
{
    public class CronusDAL
    {
        private SqlConnection connection;
        private Database database;

        public CronusDAL()
        {
            database = new Database();
            connection = database.Connection;
        }

        public List<string> GetColumnNames(string tableName)
        {

            List<string> result = new List<string>();

            try
            {
                if (database.IsConnect(connection))
                {
                    connection.Open();
                    DataTable datatable = connection.GetSchema("Columns", new string[4] { null, null, tableName, null });
                    foreach (DataRow row in datatable.Rows)
                    {
                        string columnname = row["Column_Name"].ToString();
                        result.Add(columnname);
                    }
                }
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (InvalidOperationException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }

            /*
             * -----------   SOLUTION 2   -----------
             * 
            try
            {
                if (database.IsConnect(connection))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM [" + tableName + "] WHERE 1=0"; // No data wanted, only schema  
                    command.CommandType = CommandType.Text;

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = reader.GetSchemaTable();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result.Add(row.Field<string>("ColumnName"));
                    }
                    reader.Close();
                }
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (InvalidOperationException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }
            */

            return result;
        }

        public List<string> GetTableNames()
        {

            List<string> result = new List<string>();

            try
            {
                if (database.IsConnect(connection))
                {
                    connection.Open();
                    DataTable datatable = connection.GetSchema("Tables");
                    foreach (DataRow row in datatable.Rows)
                    {
                        string tablename = row[2].ToString();
                        result.Add(tablename);
                    }
                }
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (InvalidOperationException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }


            /*
             * -----------   SOLUTION 2   -----------
             * 
            string tsql = "SELECT name FROM sys.tables";

            try
            {
                if (database.IsConnect(connection))
                {
                    SqlCommand command = new SqlCommand(tsql, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        result.Add(reader.GetString(0));
                    }
                }
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (InvalidOperationException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }
            */

            return result;
        }

        public List<MetadataItem> GetIndexes(string tableName)
        {

            List<MetadataItem> metadata = new List<MetadataItem>();
            string tsql = "SELECT" +
                                " name AS Index_Name," +
                                " type_desc As Index_Type," +
                                " is_unique," +
                                " OBJECT_NAME(object_id) As Table_Name" +
                          " FROM" +
                                " sys.indexes" +
                          " WHERE" +
                                " is_hypothetical = 0 AND" +
                                " index_id != 0 AND" +
                                " OBJECT_NAME(object_id) = '" + tableName + "'";

            try
            {
                if (database.IsConnect(connection))
                {

                    SqlCommand command = new SqlCommand(tsql, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        MetadataItem item = new MetadataItem()
                        {
                            IndexName = reader.GetString(reader.GetOrdinal("Index_Name")),
                            IndexType = reader.GetString(reader.GetOrdinal("Index_Type")),
                            IsUnique = reader.GetBoolean(reader.GetOrdinal("is_unique")),
                            TableName = reader.GetString(reader.GetOrdinal("Table_Name"))
                        };
                        metadata.Add(item);
                    }
                }
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (InvalidOperationException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }

            return metadata;
        }

        public List<MetadataItem> GetConstraints(string tableName)
        {
            List<MetadataItem> metadata = new List<MetadataItem>();
            string tsql = "SELECT ccu.COLUMN_NAME, ccu.CONSTRAINT_NAME, tc.CONSTRAINT_TYPE " +
                          " FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS tc" +
                                " INNER JOIN INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE AS ccu" +
                                    " ON tc.CONSTRAINT_NAME = ccu.CONSTRAINT_NAME" +
                            " WHERE tc.TABLE_CATALOG = 'SYSA14'" +
                               " AND tc.TABLE_SCHEMA = 'dbo'" +
                               " AND tc.TABLE_NAME = '" + tableName + "'";

            try
            {
                if (database.IsConnect(connection))
                {
                    SqlCommand command = new SqlCommand(tsql, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        metadata.Add(new MetadataItem(
                            reader.GetString(reader.GetOrdinal("COLUMN_NAME")),
                            reader.GetString(reader.GetOrdinal("CONSTRAINT_NAME")),
                            reader.GetString(reader.GetOrdinal("CONSTRAINT_TYPE"))
                        ));
                    }
                }
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (InvalidOperationException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }

            return metadata;
        }

        public List<string[]> GetTableContent(string tableName)
        {

            List<string[]> result = new List<string[]>();
            string tsql = "SELECT * FROM [" + tableName + "]";

            try
            {
                if (database.IsConnect(connection))
                {
                    SqlCommand command = new SqlCommand(tsql, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] temp = new string[reader.FieldCount];

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            temp[i] = reader.GetValue(i).ToString();
                        }

                        result.Add(temp);
                    }
                }
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (InvalidOperationException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }

            return result;
        }
    }
}
