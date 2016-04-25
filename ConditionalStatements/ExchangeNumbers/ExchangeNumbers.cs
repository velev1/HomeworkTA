using System;

class ExchangeNumbers
{
    static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());

        if (a>b)
        {
            double temp = a;
            a = b;
            b = temp;
            Console.WriteLine("{0} {1}",a,b);
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
