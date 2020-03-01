using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Customer
    {
        private List<Account> accounts;
        string FirstName { get; set; }
        string LastName { get; set; }
        Address address;

        public void Add(Account c)
        {

            accounts.Add(c);

        }

        public void Edit(int i,Account c)
        {

            accounts[i] = c;

        }

        public void Delete(Account c)
        {

            accounts.Remove(c);

        }

        public Account Access(int index)
        {

            return accounts[index];

        }
        public Customer(string firstName,string lastName,Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            this.address = address;
        }
    }
}
