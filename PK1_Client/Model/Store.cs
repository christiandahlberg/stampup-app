using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK1_Client.Model
{
    public class Store
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Created_at { get; set; }

        public Store(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public Store(int id, string name, string address, DateTime created_at)
        {
            ID = id;
            Name = name;
            Address = address;
            Created_at = created_at;
        }
    }
}
