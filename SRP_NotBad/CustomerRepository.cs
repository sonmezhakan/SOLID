using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_NotBad
{
    public class CustomerRepository
    {
        public void Create(Customer customer)
        {
            //Customer List Added
            CustomerData.customers.Add(customer);
        }
    }
}
