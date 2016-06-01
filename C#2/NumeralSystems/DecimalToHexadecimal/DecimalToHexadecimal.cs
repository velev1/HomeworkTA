using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        string result = "";

        long remainder = 0;

        while (number > 0)
        {
            remainder = number % 16;


            switch (remainder)
            {
                case 10: number /= 16; result = "A" + result; break;
                case 11: number /= 16; result = "B" + result; break;
                case 12: number /= 16; result = "C" + result; break;
                case 13: number /= 16; result = "D" + result; break;
                case 14: number /= 16; result = "E" + result; break;
                case 15: number /= 16; result = "F" + result; break;
                default:
                    number /= 16;
                    result = remainder.ToString() + result;
                    break;
            }
        }
        Console.WriteLine(result);

    }
}

