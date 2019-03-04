using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS2_Console_Client.ServiceReference;

namespace WS2_Console_Client
{
    class Program
    {

        public static WS2_Console_Client.ServiceReference.GetEntitiesSoapClient proxy = new ConsoleClientWS2.ServiceReference.GetEntitiesSoapClient();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the web service programming assignment 2 console application.\n");
            PrintInstructions();

            string input;

            while ((input = Console.ReadLine()) != "0")
            {
                switch (input)
                {
                    case "1":
                        PrintCustomers();
                        break;
                    case "2":
                        PrintStores();
                        break;
                    case "3":
                        PrintOffers();
                        break;
                    case "4":
                        PrintSubscriptions();
                        break;
                }
                PrintInstructions();
            }
        }

        public static void PrintInstructions()
        {
            Console.WriteLine("--------------------------------------------" +
                              "\nEnter numbered command for desired function: " +
                              "\n1: Get customers" +
                              "\n2: Get stores" +
                              "\n3: Get offers" +
                              "\n4: Get subscriptions (offer/customer)" +
                              "\n0: Exit application" +
                              "\n--------------------------------------------");
        }

        public static void PrintCustomers()
        {
            foreach (Customer customer in proxy.GetCustomers())
            {
                Console.WriteLine("-------------------------------\nID: {0}\nName: {1}\nEmail: {2}\nPhone: {3}\nCreated at: {4}",
                    customer.ID, customer.Name, customer.Email, customer.Phone, customer.Created_at);
            }
        }


        public static void PrintStores()
        {
            foreach (Store store in proxy.GetStores())
            {
                Console.WriteLine("-------------------------------\nID: {0}\nName: {1}\nAddress: {2}\nCreated at: {3}",
                    store.ID, store.Name, store.Address, store.Address);
            }
        }

        public static void PrintOffers()
        {
            foreach (Offer offer in proxy.GetOffers())
            {
                Console.WriteLine("-------------------------------\nID: {0}\n Name: {1}\nDescription: {2}\nStamp goal: {3}\nStore: {4}\nCreated at: {5}",
                    offer.ID, offer.Name, offer.Description, offer.StampGoal, offer.Store.Name, offer.Created_at);
            }
        }
        public static void PrintSubscriptions()
        {
            foreach (Subscription subscription in proxy.GetSubscriptions())
            {
                Console.WriteLine("-------------------------------\nCustomer ID: {0}\nOffer ID: {1}\nStamps attained: {2}\nCreated at: {3}",
                    subscription.customer_Id, subscription.offer_Id, subscription.stamps_attained, subscription.created_at);
            }
        }
    }
}