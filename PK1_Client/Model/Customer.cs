using PK1_Client.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK1_Client.Model
{
    public class Customer
    {
        public string HashedPassword { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Created_at { get; set; }
        public List<Offer> offerList;

        // Used to create new customer. Created_at is assigned in SQL-querry
        public Customer(string name, string email, string phone, string password)
        {
            Name = name;
            Email = email;
            Phone = phone;
            HashedPassword = PasswordHasher.Hash(password);
        }

        // Used to get customers from database
        public Customer(int id, string name, string email, string phone, DateTime created_at)
        {
            ID = id;
            Name = name;
            Email = email;
            Phone = phone;
            Created_at = created_at;
        }

        public void AddOffer(Offer offer)
        {
            offerList.Add(offer);
        }

    }
}