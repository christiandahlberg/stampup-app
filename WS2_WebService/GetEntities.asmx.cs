using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;



namespace WS2_WebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
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

            [WebMethod]
            public List<Customer> GetCustomers()
            {

                CustomerDAL customerDAL = new CustomerDAL();
                List<Customer> customerList = customerDAL.GetAllCustomers();

                return customerList;
            }

            [WebMethod]
            public List<Store> GetStores()
            {

                StoreDAL storeDAL = new StoreDAL();
                List<Store> storeList = storeDAL.GetAllStores();

                return storeList;
            }

            [WebMethod]
            public List<Offer> GetOffers()
            {

                OfferDAL offerDAL = new OfferDAL();
                List<Offer> offerList = offerDAL.GetAllOffers();

                return offerList;
            }

            [WebMethod]
            public List<Subscription> GetSubscriptions()
            {
                OfferDAL subscriptionDAL = new OfferDAL();
                List<Subscription> subscriptionList = subscriptionDAL.GetSubscriptions();

                return subscriptionList;
            }
        }
    }
}
