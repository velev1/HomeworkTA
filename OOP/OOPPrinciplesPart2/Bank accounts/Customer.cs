namespace Bank_accounts
{
    using System;
    using System.Text;
    using Enums;

    public abstract class Customer : IAccount
    {
        private static int nextID = 0;

        public Customer(decimal initialDeposit, DateTime dateOfcreation, CustomerType customerType, decimal interestRate)
        {
            this.Balance = initialDeposit;
            this.CreatedOn = dateOfcreation;
            this.CustomerType = customerType;
            this.InterestRate = interestRate;
            this.CustomerID = ++nextID;

        }

        public decimal Balance { get; protected set; }

        public decimal InterestRate { get; private set; }

        public CustomerType CustomerType { get; private set; }

        public DateTime CreatedOn { get; private set; }

        public int CustomerID { get; private set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.Append(string.Format("Customer data: {0}, Id: {1}, Balance: {2}, Interest rate: {3}",
                CustomerType,CustomerID,Balance,InterestRate));

            return str.ToString();
        }

        public virtual decimal Interest()
        {
            int numberOfMonths = (int)(DateTime.Now - CreatedOn).TotalDays / 30;
            decimal interest = numberOfMonths * InterestRate;

            return interest;
        }

        public virtual void DepositeMoney(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("The amount of money must be greater than zero.");
            }
            Balance += amount;
        }

        public virtual void DrowMoney(decimal amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentException("There is not enough money in your Balance");
            }
            Balance -= amount;
        }
    }
}
