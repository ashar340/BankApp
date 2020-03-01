namespace BankApp
{
    public class AccountHelper
    {
        public Account GetAccount(int accountID)
        {
           
            return new Account();
        }
        public bool IsValidAccount(int accountID)
        {
            
            return true;
        }
        public bool IsValidAmount(double amount)
        {
           
            return amount > 0;
        }
        public bool IsSufficientAmount(Account account, double amount)
        {
           
            if (account == null)
                return false;

            return account.Transactions >= amount;
        }
        public void DepositToAccount(int accountID, double amount)
        {
            Account account = null;

            if (!IsValidAmount(amount))
                throw new InvalidAmountException();

            if (!IsValidAccount(accountID))
                throw new InvalidAccountException();

            account = GetAccount(accountID);

            account.Deposit(amount);
        }
        public void WithdrawFromAccount(int accountID, double amount)
        {
            Account account = null;

            if (!IsValidAmount(amount))
                throw new InvalidAmountException();

            if (!IsValidAccount(accountID))
                throw new InvalidAccountException();

            account = GetAccount(accountID);

            if (!IsSufficientAmount(account, amount))
                throw new InsufficientBalanceException();

            account.Debit(amount);
        }
    }
}
