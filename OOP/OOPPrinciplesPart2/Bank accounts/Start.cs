namespace Bank_accounts
{
    using System;
    using System.Collections.Generic;

    public class Start
    {
        static void Main()
        {
            Customer d1 = new Deposit(10000, new DateTime(2013, 1, 15), Enums.CustomerType.Companie, 6);
            Customer d2 = new Mortgage(2000, new DateTime(2016, 11, 9), Enums.CustomerType.Individual, 4);
            Customer d3 = new Loan(3000, new DateTime(2014, 11, 5), Enums.CustomerType.Individual, 5);
            Customer d4 = new Deposit(4500, new DateTime(2010, 7, 9), Enums.CustomerType.Companie, 5);

            
            List<Customer> customers = new List<Customer>();
            
            customers.Add(d1);
            customers.Add(d2);
            customers.Add(d3);
            customers.Add(d4);

            foreach (var item in customers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("============================================================================");
            Console.WriteLine("Test the methods DrowMoney and DepositeMoney");
            Console.WriteLine("the customer before calling the methods");
            Console.WriteLine(d2.ToString());
            Console.WriteLine("----------------------------------------------------------------------------");
            d2.DrowMoney(1000);
            d2.DepositeMoney(1000);
            Console.WriteLine("the customer after the methods");
            Console.WriteLine(d2.ToString());
            Console.WriteLine("----------------------------------------------------------------------------");

            
            Console.WriteLine("the customer before calling the methods");
            Console.WriteLine(d1.ToString());
            Console.WriteLine("----------------------------------------------------------------------------");
            d1.DrowMoney(500);
            d1.DepositeMoney(1000);
            Console.WriteLine("the customer after the methods");
            Console.WriteLine(d1.ToString());
        }
    }
}
