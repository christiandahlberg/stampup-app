using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PK1_Client.DAL;
using PK1_Client.Model;

namespace PK1_Client.Controller
{
    public class OfferController : Controller
    {
        private OfferDAL offerDAL;

        public OfferController()
        {
            offerDAL = new OfferDAL();
        }

        // Returns offer if found
        public List<Offer> GetOffersByStoreId(int id)
        {
            return offerDAL.GetOffersByStoreId(id);
        }

        public List<Offer> GetAllOffers()
        {
            return offerDAL.GetAllOffers();
        }

        public Offer GetOfferByOfferID(int id)
        {
            List<Offer> offerList = GetAllOffers();
            foreach (Offer offer in offerList)
            {
                if (offer.ID == id)
                {
                    return offer;
                }
            }
            return null;
        }

        public Boolean CreateOffer(string name, string description, Store store, int stampGoal)
        {
            Offer offer = new Offer(name, description, store, stampGoal);
            return offerDAL.CreateOffer(offer);
        }

        public Boolean RemoveOffer(int oID)
        {
            return offerDAL.RemoveOffer(oID);
        }

        public Boolean UpdateOffer(Offer offer)
        {
            return offerDAL.UpdateOffer(offer);
        }

        public string GetOfferDescription(int oId)
        {
            return offerDAL.GetOfferDescription(oId);
        }

        // List
        public List<Offer> GetCustomerOffers(int cId, int sId)
        {
            return offerDAL.GetCustomerOffers(cId, sId);
        }

        public List<Offer> GetCustomerOffersById(int cId)
        {
            return offerDAL.GetCustomerOffersById(cId);
        }

        // Add customer to offer (Subscriptions)
        public Boolean AddSubscription(int oId, int cId)
        {
            return offerDAL.AddSubscription(oId, cId);
        }

        public Boolean RemoveSubscription(Offer o, int cId)
        {
            return offerDAL.RemoveSubscriptions(cId, o);
        }

        public Boolean FindSubscription(int oId, int cId)
        {
            return offerDAL.FindSubscription(oId, cId);
        }
    }
}
