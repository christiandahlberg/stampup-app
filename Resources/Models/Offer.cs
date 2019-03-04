using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources.Models
{
    public class Offer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StampGoal { get; set; }
        public Store Store { get; set; }
        public DateTime Created_at { get; set; }

        // Used when fetching offer (OfferGUI)
        public Offer() { }

        // Used to create new offer. Created_at is assigned in SQL-querry
        public Offer(string name, string description, Store store, int stampGoal)
        {
            Name = name;
            Description = description;
            Store = store;
            StampGoal = stampGoal;
        }

        // Used to get offer from database
        public Offer(int id, Store store, int stampGoalAmount, string name, DateTime created_at)
        {
            ID = id;
            Store = store;
            Name = name;
            StampGoal = stampGoalAmount;
            Created_at = Created_at;
        }

        // Used when getting specific offer for customer
        public Offer(int offer_id, string offer_name, string offer_desc, int offer_stampgoal)
        {
            ID = offer_id;
            Name = offer_name;
            Description = offer_desc;
            StampGoal = offer_stampgoal;
        }

        // New constructor used for updating in adminGUI
        public Offer(int offerId, string name, string description, Store store, int stampGoal, DateTime created)
        {
            ID = offerId;
            Name = name;
            Description = description;
            Store = store;
            StampGoal = stampGoal;
            Created_at = created;

        }
    }
}
