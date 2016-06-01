using System;

class AppearanceCount
{
    static int GetNumberCount(string[] numbers, int number)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (Convert.ToInt32(numbers[i]) == number)
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int x = int.Parse(Console.ReadLine());

        int numberCount = GetNumberCount(input, x);
        Console.WriteLine(numberCount);
    }
}

