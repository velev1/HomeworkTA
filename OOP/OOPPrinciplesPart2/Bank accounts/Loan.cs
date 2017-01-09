namespace Bank_accounts
{
    using System;
    using Enums;

    public class Loan : Customer
    {
        public Loan(decimal deposit, DateTime dateOfcreation, CustomerType customerType, decimal interestRate)
            :base(deposit, dateOfcreation, customerType, interestRate)
        {

        }

        public override decimal Interest()
        {
            decimal interest = 0;
            int numberOfMonths = (int)(DateTime.Now - CreatedOn).TotalDays / 30;
            switch (CustomerType)
            {
                case CustomerType.Individual:

                    if (numberOfMonths <= 3)
                    {
                        return 0;
                    }
                    interest = numberOfMonths * (InterestRate / 100);
                    return interest;
                    
                case CustomerType.Companie:
                    if (numberOfMonths <= 2)
                    {
                        return 0;
                    }
                    interest = numberOfMonths * (InterestRate / 100);
                    return interest;
            }
            throw new ArgumentException("The customer type is not defined.");
        }

        public override void DrowMoney(decimal amount)
        {
            Console.WriteLine("You cant drow money from your balance because of your account type.");
        }
    }
}
