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
    public class OfferDAL
    {
        private Database database;
        private SqlConnection connection;
        private StoreDAL storeDAL;

        public OfferDAL()
        {
            database = new Database();
            connection = database.Connection;
            storeDAL = new StoreDAL();
        }

        public List<Offer> GetAllOffers() // klar i controller
        {
            List<Offer> offerList = new List<Offer>();
            string tsql = "SELECT * FROM Offer";
            SqlCommand command = new SqlCommand(tsql, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    Store oStore = storeDAL.GetStoreById(reader.GetInt32(reader.GetOrdinal("store_id")));

                    if (oStore != null)
                    {
                        Offer offer = new Offer()
                        {
                            ID = reader.GetInt32(reader.GetOrdinal("id")),
                            Name = reader.GetString(reader.GetOrdinal("name")),
                            Description = reader.GetString(reader.GetOrdinal("description")),
                            StampGoal = reader.GetInt32(reader.GetOrdinal("stamp_goal")),
                            Store = oStore,
                            Created_at = reader.GetDateTime(reader.GetOrdinal("created"))
                        };

                        offerList.Add(offer);
                    }

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

            return offerList;
        }

        public Boolean CreateOffer(Offer offer) // klar i controller 
        {
            Boolean success = false;

            string tsql = "INSERT INTO Offer VALUES (@oName, @oDesc, @oStampGoal, @storeID, DEFAULT)";

            SqlCommand command = new SqlCommand(tsql, connection);

            try
            {
                command.Parameters.Add("@oName", SqlDbType.NVarChar).Value = offer.Name;
                command.Parameters.Add("@oDesc", SqlDbType.NVarChar).Value = offer.Description;
                command.Parameters.Add("@oStampGoal", SqlDbType.NVarChar).Value = offer.StampGoal;
                command.Parameters.Add("@storeID", SqlDbType.NVarChar).Value = offer.Store.ID;

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

        public Boolean RemoveOffer(int oID) //klar i controller 
        {
            Boolean success = false;

            string tsql = "DELETE FROM Offer WHERE id = @oID";
            SqlCommand command = new SqlCommand(tsql, connection);

            try
            {
                command.Parameters.Add("@oID", SqlDbType.NVarChar).Value = oID;

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

        public Boolean UpdateOffer(Offer offer)  // klar i controller 
        {
            Boolean success = false;
            string tsql = "UPDATE Offer SET " +
                "name = @oName, " +
                "description = @oDesc, " +
                "stamp_goal = @stampGoal, " +
                "store_id = @storeID " +
                "WHERE id = @oID";

            SqlCommand command = new SqlCommand(tsql, connection);

            command.Parameters.Add("@oName", SqlDbType.NVarChar).Value = offer.Name;
            command.Parameters.Add("@oDesc", SqlDbType.NVarChar).Value = offer.Description;
            command.Parameters.Add("@stampGoal", SqlDbType.Int).Value = offer.StampGoal;
            command.Parameters.Add("@storeID", SqlDbType.Int).Value = offer.Store.ID;
            command.Parameters.Add("@oID", SqlDbType.Int).Value = offer.ID;

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

        // Returns description of offer
        public string GetOfferDescription(int oId)
        {
            string tsql = "SELECT description FROM Offer WHERE offer_id = @oId";

            // Create command and add parameters
            SqlCommand command = new SqlCommand(tsql, connection);
            command.Parameters.Add("@oId", SqlDbType.Int).Value = oId;

            try
            {
                if (database.IsConnect(connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader.GetString(reader.GetOrdinal("description"));
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

            return null;
        }

        public List<Offer> GetCustomerOffers(int cId, int sId)
        {
            List<Offer> customer_offer_list = new List<Offer>();
            string tsql = "SELECT * FROM Offer JOIN Customer_Offer ON id = offer_id WHERE customer_id = @customer_id AND store_id = @store_id";

            // Create command and add parameters
            SqlCommand command = new SqlCommand(tsql, connection);
            command.Parameters.Add("@customer_id", SqlDbType.Int).Value = cId;
            command.Parameters.Add("@store_id", SqlDbType.Int).Value = sId;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    Offer offer = new Offer()
                    {
                        Name = reader.GetString(reader.GetOrdinal("name")),
                        Description = reader.GetString(reader.GetOrdinal("description")),
                        StampGoal = reader.GetInt32(reader.GetOrdinal("stamp_goal")),
                        ID = reader.GetInt32(reader.GetOrdinal("offer_id"))
                    };

                    customer_offer_list.Add(offer);
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

            return customer_offer_list;
        }

        public Offer GetCustomerOffer(int cId, int sId)
        {
            string tsql = "SELECT * FROM Offer JOIN Customer_Offer ON id = offer_id WHERE customer_id = @customer_id AND store_id = @store_id; ";

            // Create command and add parameters
            SqlCommand command = new SqlCommand(tsql, connection);
            command.Parameters.Add("@customer_id", SqlDbType.Int).Value = cId;
            command.Parameters.Add("@store_id", SqlDbType.Int).Value = sId;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    Offer offer = new Offer()
                    {
                        Name = reader.GetString(reader.GetOrdinal("name")),
                        Description = reader.GetString(reader.GetOrdinal("description")),
                        StampGoal = reader.GetInt32(reader.GetOrdinal("stamp_goal")),
                        ID = reader.GetInt32(reader.GetOrdinal("offer_id"))
                    };

                    return offer;
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

            return null;
        }

        // Returns store if found
        public List<Offer> GetOffersByStoreId(int id) // klar i controller 
        {
            List<Offer> offerList = new List<Offer>();
            foreach (Offer offer in GetAllOffers())
            {
                if (offer.Store.ID == id)
                {
                    offerList.Add(offer);
                }
            }

            return offerList;
        }

        public List<Offer> GetCustomerOffersById(int cId)
        {
            List<Offer> customer_offers = new List<Offer>();
            string tsql = "SELECT * FROM Offer JOIN Customer_Offer ON id = offer_id WHERE customer_id = @customer_id";

            // Create command and add parameters
            SqlCommand command = new SqlCommand(tsql, connection);
            command.Parameters.Add("@customer_id", SqlDbType.Int).Value = cId;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Offer offer = new Offer()
                    {
                        Name = reader.GetString(reader.GetOrdinal("name")),
                        Description = reader.GetString(reader.GetOrdinal("description")),
                        StampGoal = reader.GetInt32(reader.GetOrdinal("stamp_goal")),
                        ID = reader.GetInt32(reader.GetOrdinal("offer_id"))
                    };

                    customer_offers.Add(offer);
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

            return customer_offers;
        }

        public Boolean RemoveSubscriptions(int cId, Offer o)
        {
            bool success = false;
            string tsql = "DELETE FROM Customer_Offer WHERE customer_id = @customer_id AND offer_id = @offer_id";

            // Create command and add parameters
            SqlCommand command = new SqlCommand(tsql, connection);
            command.Parameters.Add("@customer_id", SqlDbType.Int).Value = cId;
            command.Parameters.Add("@offer_id", SqlDbType.Int).Value = o.ID;

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

        public Boolean AddSubscription(int oId, int cId)
        {
            bool success = false;
            string tsql = "INSERT INTO Customer_Offer VALUES (@cId, @oId, 0, DEFAULT)";

            // Create command and add parameters
            SqlCommand command = new SqlCommand(tsql, connection);
            command.Parameters.Add("@cId", SqlDbType.Int).Value = cId;
            command.Parameters.Add("@oId", SqlDbType.Int).Value = oId;

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

        public Boolean FindSubscription(int oId, int cId)
        {
            bool success = false;

            string tsql = "SELECT * FROM Customer_Offer WHERE customer_id = @customer_id AND offer_id = @offer_id";

            // Create command and add parameters
            SqlCommand command = new SqlCommand(tsql, connection);
            command.Parameters.Add("@customer_id", SqlDbType.Int).Value = cId;
            command.Parameters.Add("@offer_id", SqlDbType.Int).Value = oId;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    success = true;
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

        public List<Subscription> GetSubscriptions()
        {
            List<Subscription> subscriptions = new List<Subscription>();
            string tsql = "SELECT * FROM Customer_Offer";
            SqlCommand command = new SqlCommand(tsql, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int customer_ID = reader.GetInt32(0);
                    int offer_ID = reader.GetInt32(1);
                    int stamps_attained = reader.GetInt32(2);
                    DateTime created_at = reader.GetDateTime(3);

                    subscriptions.Add(new Subscription(customer_ID, offer_ID, stamps_attained, created_at));

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

            return subscriptions;
        }
    }
}
