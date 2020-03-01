using System;

namespace BankApp
{
    public class InvalidNumberOfAccountsException : Exception
    {
       
        public InvalidNumberOfAccountsException() { }

        public InvalidNumberOfAccountsException(string message)
        : base(message) { }

        public InvalidNumberOfAccountsException(string message, Exception inner)
        : base(message, inner) { }
    }
}
