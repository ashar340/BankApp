using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Branch
    {
        private List<Customer> customers;
        private Address address;
        public Address myaddress { get { return address; }set { address = value; } }

        public Branch(Address a)
        {
            address = a;
            customers = new List<Customer>();
        }

        public void Add(Customer c)
        {
            customers.Add(c);
        }
        public void Edit(int i,Customer c)
        {
            customers[i] = c;
        }
        public void Delete(Customer c)
        {
            customers.Remove(c);
        }
        public Customer Access(int index)
        {
            return customers[index];
        }
    }
}
