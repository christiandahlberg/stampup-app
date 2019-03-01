using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PK1_Client.Model;
using Resources;


namespace PK1_Client.DAL
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
                    int oID = reader.GetInt32(0);
                    string oName = reader.GetString(1);
                    string oDesc = reader.GetString(2);
                    int oGoalAmount = reader.GetInt32(3);
                    int storeID = reader.GetInt32(4);
                    DateTime created_at = reader.GetDateTime(5);

                    Store oStore = storeDAL.GetStoreById(storeID);

                    if (oStore != null)
                    {
                        offerList.Add(new Offer(oID, oName, oDesc, oStore, oGoalAmount, created_at));
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
            string description = null;

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
                        description = reader.GetString(0);
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

            return description;
        }

        public List<Offer> GetCustomerOffers(int cId, int sId)
        {
            List<Offer> customer_offer_list = new List<Offer>();
            string tsql = "SELECT * FROM Offer JOIN Customer_Offer ON id = offer_id WHERE customer_id = @customer_id AND store_id = @store_id; ";

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
                    string offer_name = reader.GetString(1);
                    string offer_desc = reader.GetString(2);
                    int offer_stampgoal = reader.GetInt32(3);
                    int offer_id = reader.GetInt32(7);

                    customer_offer_list.Add(new Offer(offer_id, offer_name, offer_desc, offer_stampgoal));
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
                    string offer_name = reader.GetString(1);
                    string offer_desc = reader.GetString(2);
                    int offer_stampgoal = reader.GetInt32(3);
                    int offer_id = reader.GetInt32(7);

                    return new Offer(offer_id, offer_name, offer_desc, offer_stampgoal);
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
                    string offer_name = reader.GetString(1);
                    string offer_desc = reader.GetString(2);
                    int offer_stampgoal = reader.GetInt32(3);
                    int offer_id = reader.GetInt32(7);

                    customer_offers.Add(new Offer(offer_id, offer_name, offer_desc, offer_stampgoal));
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
    }
}