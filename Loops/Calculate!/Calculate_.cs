using System;

class Calculate_
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        double x = Convert.ToDouble(Console.ReadLine());
        double sum = 1.0;
        long fact = 1;
      
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
            sum += fact / Math.Pow(x, i);
        }
        Console.WriteLine("{0:F5}",sum);
    }
}
