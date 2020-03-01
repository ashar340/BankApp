using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Bank
    {
       private List<Branch> branches;
        private string name;
        public Bank(string n)
        {
            name = n;
            branches = new List<Branch>();
        }

        public void Add(Branch b)
        {
            branches.Add(b);
        }

        public void Edit(int i,Branch b)
        {
            branches[i] = b;
        }
        public void Delete(Branch b)
        {
            branches.Remove(b);
        }
        public Branch Access(int index)
        {
            return branches[index];
        }
        

    }
}
