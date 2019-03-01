using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PK1_Client.DAL;
using PK1_Client.Model;

namespace PK1_Client.Controller
{
    public class StoreController : Controller
    {
        private StoreDAL storeDAL;

        public StoreController()
        {
            storeDAL = new StoreDAL();
        }

        // Return list of all stores in db
        public List<Store> GetAllStores()
        {
            return storeDAL.GetAllStores();
        }

        // Create new store and save to db
        public Boolean CreateStore(string name, string address)
        {
            return storeDAL.CreateStore(new Store(name, address));
        }

        // Update store information
        public Boolean UpdateStore(int id, string name, string address)
        {
            return storeDAL.UpdateStore(id, name, address);
        }

        // Returns store if found
        public Store GetStoreById(int id)
        {
            return storeDAL.GetStoreById(id);
        }

        // Return amount of subscriptions in store
        public int GetTotalSubscriptions(int store_id)
        {
            return storeDAL.GetTotalSubscriptions(store_id);
        }

        public Boolean RemoveStore(int id)
        {
            return storeDAL.RemoveStore(id);
        }
    }


}
