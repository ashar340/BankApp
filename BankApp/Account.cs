using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
   public abstract class Account
    {
       public double balance;
        public string accountNumber;
        public double Transactions { get { return balance; } set { balance = value; } }
       

        public Account(string accountNumber)
        {
            this.accountNumber = accountNumber;
            
        }

        public void Deposit(double amount)
        {
            Transactions += amount;
        }

        public void Debit(double amount)
        {
            Transactions -= amount;
        }

    }
}
