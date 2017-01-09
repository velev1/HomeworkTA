namespace Bank_accounts
{
    using System;
    using Enums;

    public class Deposit : Customer
    {

        public Deposit(decimal deposit, DateTime dateOfcreation, CustomerType customerType, decimal interestRate)
            :base(deposit, dateOfcreation, customerType, interestRate)
        {

        }

        public override decimal Interest()
        {
            decimal interest = 0;
            int numberOfMonths = (int)(DateTime.Now - CreatedOn).TotalDays / 30;

            if (Balance > 1000)
            {
                interest = numberOfMonths * (InterestRate / 100);
            }
            return interest;
        }
    }
}
