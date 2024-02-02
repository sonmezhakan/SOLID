using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Bad
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static List<Customer> customers = new List<Customer>();//List Created

        public void Create(Customer customer)
        {
            //Customer List Added
            customers.Add(customer);
        }

        public void DatabaseConnect()
        {
            //Database Connection
        }
        public void DatabaseDisconnect()
        {
            //Database Disconnect
        }
    }
}
