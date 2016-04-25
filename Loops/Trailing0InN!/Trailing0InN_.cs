using System;

class Trailing0InN_
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int zeros = 0;
        int temp = 0;

        for (int i = n; i > 0; i--)
        {
            if (i % 5 == 0)
            {
                temp = i;

                while (temp >=5 && temp % 5 ==0)
                {
                    temp = temp / 5;
                    zeros++;
                }
            }
        }
        Console.WriteLine(zeros);
    }
}

