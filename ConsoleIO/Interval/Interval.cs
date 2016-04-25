using System;

class Interval
{
    static void Main()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        int M = Convert.ToInt32(Console.ReadLine());
        
        int counter = 0;
        for (int i = N + 1; i < M; i++)
        {
            if (i % 5 ==0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}

