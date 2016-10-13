using System;

class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i * -1);
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}

