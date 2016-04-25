using System;

class OddOrEven
{
    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input % 2 == 0)
        {
            Console.WriteLine("even {0}", input);
        }
        else
        {
            Console.WriteLine("odd {0}", input);
        }
    }
}

