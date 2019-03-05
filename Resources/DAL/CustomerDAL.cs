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
    public class CustomerDAL
    {
        private Database database;
        private SqlConnection connection;

        public CustomerDAL()
        {
            database = new Database();
            connection = database.Connection;
        }

        // Returns a list of all customers currently in the database.
        public List<Customer> GetAllCustomers()
        {
            List<Customer> customerList = new List<Customer>();
            string tsql = "SELECT * FROM Customer";
            SqlCommand command = new SqlCommand(tsql, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    int cID = reader.GetInt32(0);
                    string cName = reader.GetString(1);
                    string cEmail = reader.GetString(2);
                    string cPhone = reader.GetString(3);
                    string password = reader.GetString(4);
                    DateTime created_at = reader.GetDateTime(5);

                    customerList.Add(
                        new Customer(cID, cName, cEmail, cPhone, created_at)
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

            return customerList;
        }

        public bool VerifyCustomer(string email, string password)
        {
            string hashedPassword = "";
            string tsql = "SELECT password FROM Customer WHERE email = @email";

            SqlCommand command = new SqlCommand(tsql, connection);
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;

            try
            {
                if (database.IsConnect(connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        hashedPassword = reader.GetString(0);
                    }
                    reader.Close();
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
            
            // Try to verify password
            try
            {
                return PasswordHasher.Verify(password, hashedPassword);
            }
            catch (NotSupportedException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }

            return false;
        }



        // Returns True if customer were successfully created.
        public Boolean CreateCustomer(Customer customer)
        {
            Boolean success = false;
            string tsql = "INSERT INTO Customer VALUES (@cName, @cEmail, @cPhone, @password, DEFAULT)";

            // Create command and add parameters
            SqlCommand command = new SqlCommand(tsql, connection);
            command.Parameters.Add("@cName", SqlDbType.NVarChar).Value = customer.Name;
            command.Parameters.Add("@cEmail", SqlDbType.NVarChar).Value = customer.Email;
            command.Parameters.Add("@cPhone", SqlDbType.NVarChar).Value = customer.Phone;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = customer.HashedPassword;

            try
            {
                if (database.IsConnect(connection))
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    success = (rowsAffected == 1) ? true : false;
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

            return success;
        }

        // Returns True if customer were successfully deleted.
        public Boolean RemoveCustomer(int cID)
        {
            Boolean success = false;

            string tsql = "DELETE FROM Customer WHERE id = @cID";
            SqlCommand command = new SqlCommand(tsql, connection);

            try
            {
                // Add parameters to command
                command.Parameters.Add("@cID", SqlDbType.Int).Value = cID;

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

        // Update customer with new password
        public Boolean UpdateCustomer(int id, string name, string email, string phone, string password)
        {
            Boolean success = false;
            string tsql = "UPDATE Customer SET name = @cName, email = @cEmail, phone = @cPhone, password = @password WHERE id = @cID";
            SqlCommand command = new SqlCommand(tsql, connection);

            // Add parameters to command
            command.Parameters.Add("@cID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@cName", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@cEmail", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@cPhone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = PasswordHasher.Hash(password);

            try
            {
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

        // Update customer without new password
        public Boolean UpdateCustomer(int id, string name, string email, string phone)
        {
            Boolean success = false;
            string tsql = "UPDATE Customer SET name = @cName, email = @cEmail, phone = @cPhone WHERE id = @cID";
            SqlCommand command = new SqlCommand(tsql, connection);

            // Add parameters to command
            command.Parameters.Add("@cID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@cName", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@cEmail", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@cPhone", SqlDbType.NVarChar).Value = phone;

            try
            {
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

        public int GetStampsAttained(int cId, int oId)
        {
            int amount = 0;

            string tsql = "SELECT stamps_attained FROM Customer_Offer WHERE customer_id = @cId AND offer_id = @oId";

            // Create command and add parameters
            SqlCommand command = new SqlCommand(tsql, connection);
            command.Parameters.Add("@cId", SqlDbType.Int).Value = cId;
            command.Parameters.Add("@oId", SqlDbType.Int).Value = oId;

            try
            {
                if (database.IsConnect(connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        amount = reader.GetInt32(0);
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
            return amount;
        }

        public Boolean IncrementStampsAttained(int cId, int oId)
        {
            Boolean success = false;
            string tsql = "UPDATE Customer_Offer SET stamps_attained = stamps_attained + 1 WHERE customer_id = @cId AND offer_id = @oId";

            // Create command and add parameters
            SqlCommand command = new SqlCommand(tsql, connection);
            command.Parameters.Add("@cId", SqlDbType.Int).Value = cId;
            command.Parameters.Add("@oId", SqlDbType.Int).Value = oId;

            try
            {
                if (database.IsConnect(connection))
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    success = (rowsAffected == 1) ? true : false;
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

            return success;
        }



        //checks if customer exists when trying to register 
        public Boolean CustomerAlreadyExists(string email)
        {
            try
            {
                foreach (Customer customer in GetAllCustomers())
                {
                    if (email == customer.Email)
                        return true;
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

            return false;
        }

    }
}
