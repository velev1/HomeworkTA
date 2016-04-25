using System;

class BiggestOf3
{
    static void Main()
    {
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        double num3 = Convert.ToDouble(Console.ReadLine());

        double max;

        if (num1 >= num2)
        {
            if (num1 >= num3)
            {
                max = num1;
                Console.WriteLine(max);
            }
            else
            {
                max = num3;
                Console.WriteLine(max);
            }
        }
        else if (num1 < num2)
        {
            if (num2 >= num3)
            {
                max = num2;
                Console.WriteLine(max);
            }
            else
            {
                max = num3;
                Console.WriteLine(max);
            }
        }
        
    }
}
