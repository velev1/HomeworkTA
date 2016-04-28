using System;

class ThirdDigit
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        number = (number / 100) % 10;
        if (number == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", number);
        }
    }
}
