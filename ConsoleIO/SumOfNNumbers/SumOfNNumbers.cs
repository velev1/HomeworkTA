using System;

class SumOfNNumbers
{
    static void Main()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        double sum = 0;

        for (int i = 0; i < N; i++)
        {
            sum += Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}
