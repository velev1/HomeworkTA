using System;

class BiggestOf5
{
    static void Main()
    {
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        double num3 = Convert.ToDouble(Console.ReadLine());
        double num4 = Convert.ToDouble(Console.ReadLine());
        double num5 = Convert.ToDouble(Console.ReadLine());

        if (num1 >= num2 && num1 >= num3 && num1>=num4 && num1>=num5)
        {
            Console.WriteLine(num1);
        }
        else if (num2 > num1 && num2>=num3 && num2>= num4 && num2 >= num5)
        {
            Console.WriteLine(num2);
        }
        else if (num3 > num1 && num3 > num2 && num3 >= num4 && num3 >=num5)
        {
            Console.WriteLine(num3);
        }
        else if (num4 > num1 && num4 >num2 && num4 > num3 && num4 >= num5)
        {
            Console.WriteLine(num4);
        }
        else 
        {
            Console.WriteLine(num5);
        }
    }
}

