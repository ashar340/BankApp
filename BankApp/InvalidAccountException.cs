using System;

namespace BankApp
{
    public class InvalidAccountException : Exception
    {
        public InvalidAccountException() { }

        public InvalidAccountException(string message)
        : base(message) { }

        public InvalidAccountException(string message, Exception inner)
        : base(message, inner) { }
    }
}
