using System;

class DivideBy7And5
{
    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        if ((input % 5 == 0) && (input % 7 == 0))
        {
            Console.WriteLine("true {0}", input);
        }
        else
        {
            Console.WriteLine("false {0}", input);
        }
    }
}

