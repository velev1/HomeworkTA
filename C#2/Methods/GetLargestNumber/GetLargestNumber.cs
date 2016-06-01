using System;

class GetLargestNumber
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        return Math.Max(firstNumber,secondNumber);
    }

    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries );

        int max = GetMax(Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1]));
        max = GetMax(max, Convert.ToInt32(numbers[2]));
        Console.WriteLine(max);
    }
}

