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
    public class StoreDAL
    {
        private Database database;
        private SqlConnection connection;

        public StoreDAL()
        {
            database = new Database();
            connection = database.Connection;
        }

        // Returns store if found
        public Store GetStoreById(int id)
        {
            foreach (Store store in GetAllStores())
            {
                if (store.ID == id)
                {
                    return store;
                }
            }

            return null;
        }

        public List<Store> GetAllStores()
        {
            List<Store> storeList = new List<Store>();
            string tsql = "SELECT * FROM Store";
            SqlCommand command = new SqlCommand(tsql, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    int sID = reader.GetInt32(0);
                    string sName = reader.GetString(1);
                    string sAddress = reader.GetString(2);
                    DateTime created_at = reader.GetDateTime(3);

                    storeList.Add(
                        new Store(sID, sName, sAddress, created_at)
                    );
                }

                reader.Close();
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (Exception e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }

            return storeList;
        }

        public Boolean CreateStore(Store store)
        {
            Boolean success = false;

            string tsql = "INSERT INTO Store VALUES (@sName, @sAddress, DEFAULT)";

            SqlCommand command = new SqlCommand(tsql, connection);

            try
            {
                // Add parameters to command
                command.Parameters.Add("@sName", SqlDbType.NVarChar).Value = store.Name;
                command.Parameters.Add("@sAddress", SqlDbType.NVarChar).Value = store.Address;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                success = (rowsAffected == 1) ? true : false;
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (Exception e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }

            return success;
        }

        public Boolean RemoveStore(int sID)
        {
            Boolean success = false;

            string tsql = "DELETE FROM Store WHERE id = @sId";
            SqlCommand command = new SqlCommand(tsql, connection);

            try
            {
                // Add parameters to command
                command.Parameters.Add("@sId", SqlDbType.Int).Value = sID;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                success = (rowsAffected == 1) ? true : false;
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (Exception e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }

            return success;
        }

        public Boolean UpdateStore(int sID, string sName, string sAddress)
        {
            Boolean success = false;
            string tsql = "UPDATE Store SET name = @sName, address = @sAddress WHERE id = @sId";
            SqlCommand command = new SqlCommand(tsql, connection);

            try
            {
                // Add parameters to command
                command.Parameters.Add("@sId", SqlDbType.Int).Value = sID;
                command.Parameters.Add("@sName", SqlDbType.NVarChar).Value = sName;
                command.Parameters.Add("@sAddress", SqlDbType.NVarChar).Value = sAddress;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                success = (rowsAffected == 1) ? true : false;
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (Exception e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }

            return success;
        }

        public int GetTotalSubscriptions(int store_id)
        {
            int count = 0;
            string tsql = "SELECT COUNT(*) FROM Customer_Offer WHERE offer_id IN " +
                            "(SELECT id FROM Offer WHERE store_id = @store_id)";

            // Create command and add parameters
            SqlCommand command = new SqlCommand(tsql, connection);
            command.Parameters.Add("@store_id", SqlDbType.Int).Value = store_id;

            try
            {
                if (database.IsConnect(connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (Exception e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }

            return count;
        }
    }
}
