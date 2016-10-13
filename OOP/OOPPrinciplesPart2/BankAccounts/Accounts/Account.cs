namespace BankAccounts.Accounts
{
    public abstract class Account
    {
        private decimal balance;
        private decimal interestRate;


        public abstract decimal CalculateBalance();

        // All accounts can calculate their interest amount for a given period(in months).
        //In the common case its is calculated as follows: number_of_months* interest_rate.
    }
}
