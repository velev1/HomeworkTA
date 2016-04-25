using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(i);
        }
    }
}

