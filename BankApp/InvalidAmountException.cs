using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class InvalidAmountException : Exception
    {
        public InvalidAmountException()
        {

        }
        public InvalidAmountException(string message):base(message)
        {

        }

        public InvalidAmountException(string message, Exception new_ex):base(message,new_ex)
        {

        }
    }
}
