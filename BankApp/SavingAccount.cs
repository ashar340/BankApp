using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class SavingAccount:Account
    {
        double InterestRate { get; set; }

        public SavingAccount(string accountNumber,double interestRate):base(accountNumber)
        {
            this.accountNumber = accountNumber;
            InterestRate = interestRate;
        }
    }
}
