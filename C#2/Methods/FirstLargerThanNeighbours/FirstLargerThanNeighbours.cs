using System;

class FirstLargerThanNeighbours
{
    static int FindIndexOfFirsBigNeighbour(string[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {

            if (i != 0 && i != numbers.Length - 1 &&
                 Convert.ToInt32(numbers[i]) > Convert.ToInt32(numbers[i - 1]) &&
                 Convert.ToInt32(numbers[i]) > Convert.ToInt32(numbers[i + 1]))
            {
                return i;
            }
        }
        return -1;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int indexOfBigNumber = FindIndexOfFirsBigNeighbour(numbers);

        Console.WriteLine(indexOfBigNumber);
    }
}

