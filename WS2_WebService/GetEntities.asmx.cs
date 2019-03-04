using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Resources.DAL;
using Resources.Models;

namespace WS2_WebService
{
    /// <summary>
    /// Summary description for GetEntities
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GetEntities : System.Web.Services.WebService
    {
        private CustomerDAL customerDAL;
        private StoreDAL storeDAL;
        private OfferDAL offerDAL;

        public GetEntities()
        {
            customerDAL = new CustomerDAL();
            storeDAL = new StoreDAL();
            offerDAL = new OfferDAL();
        }

        [WebMethod]
        public List<Customer> GetCustomers()
        {
            List<Customer> customerList = customerDAL.GetAllCustomers();
            return customerList;
        }

        [WebMethod]
        public List<Store> GetStores()
        {
            List<Store> storeList = storeDAL.GetAllStores();
            return storeList;
        }

        [WebMethod]
        public List<Offer> GetOffers()
        {
            List<Offer> offerList = offerDAL.GetAllOffers();
            return offerList;
        }

        [WebMethod]
        public List<Subscription> GetSubscriptions()
        {
            List<Subscription> subscriptionList = offerDAL.GetSubscriptions();
            return subscriptionList;
        }
    }
}
