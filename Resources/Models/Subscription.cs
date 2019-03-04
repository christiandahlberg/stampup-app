using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources.Models
{
    public class Subscription
    {
        public int customer_Id, offer_Id, stamps_attained;
        public DateTime created_at;

        public Subscription() { }

        public Subscription(int customerId, int offerId, int stamps, DateTime created_at)
        {
            customer_Id = customerId;
            offer_Id = offerId;
            stamps_attained = stamps;
            this.created_at = created_at;
        }
    }
}
