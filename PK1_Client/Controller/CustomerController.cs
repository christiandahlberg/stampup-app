using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Resources.DAL;
using Resources.Models;

namespace PK1_Client.Controller
{
    public class CustomerController : Controller
    {
        private CustomerDAL customerDAL;

        public CustomerController()
        {
            customerDAL = new CustomerDAL();
        }
        
        public Boolean CreateCustomer(string name, string email, string phone, string password)
        {
            if (!CustomerAlreadyExists(email))
            {
                return customerDAL.CreateCustomer(new Customer(name, email, phone, password));
            }
            else
            {
                return false;
            }
        }
        
        public Boolean RemoveCustomer(int cId)
        {
            OfferController c = new OfferController();
            OfferDAL offerDAL = new OfferDAL();

            foreach (Offer o in c.GetCustomerOffersById(cId))
            {
                offerDAL.RemoveSubscriptions(cId, o);
            }
            return customerDAL.RemoveCustomer(cId);
        }
        
        public Boolean UpdateCustomer(int id, string name, string email, string phone, string password)
        {
            return customerDAL.UpdateCustomer(id, name, email, phone, password);
        }
        
        public Boolean UpdateCustomer(int id, string name, string email, string phone)
        {
            return customerDAL.UpdateCustomer(id, name, email, phone);
        }

        public List<Customer> GetAllCustomers()
        {
            return customerDAL.GetAllCustomers();
        }

        public Customer GetCustomerById(int id)
        {
            List<Customer> customerList = GetAllCustomers();
            foreach (Customer customer in customerList)
            {
                if (customer.ID == id)
                {
                    return customer;
                }
            }

            return null;
        }

        public bool VerifyCustomer(string email, string password)
        {
            return customerDAL.VerifyCustomer(email, password);
        }

        public Boolean CustomerAlreadyExists(string email)
        {
            return customerDAL.CustomerAlreadyExists(email);
        }

        public Customer GetCustomerByEmail(string email)
        {
            List<Customer> customerList = GetAllCustomers();
            foreach (Customer customer in customerList)
            {
                if (customer.Email == email)
                {
                    return customer;
                }
            }

            return null;
        }

        public int GetStampsAttained(int cId, int oId)
        {
            return customerDAL.GetStampsAttained(cId, oId);
        }
    }
}