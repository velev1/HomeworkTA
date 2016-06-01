using System;

class SumIntegers
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += Convert.ToInt32(numbers[i]);
        }
        Console.WriteLine(sum);
    }
}

