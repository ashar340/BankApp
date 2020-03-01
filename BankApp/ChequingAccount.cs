using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class ChequingAccount:Account
    {
        double MonthlyFee { get; set; }

        public ChequingAccount(string accountNumber,double MonthlyFee):base(accountNumber)

        {
            this.MonthlyFee = MonthlyFee;
        }
    }
}
