using System;

class LargerThanNeighbours
{
    static int FindCountOfGreaterNeighbours(string[] numbers)
    {
        int bigNeighbour = 0;
        for (int i = 0; i < numbers.Length; i++)
        {

            if (i != 0 && i != numbers.Length - 1 &&
                 Convert.ToInt32(numbers[i]) > Convert.ToInt32(numbers[i - 1]) &&
                 Convert.ToInt32(numbers[i]) > Convert.ToInt32(numbers[i + 1]))
            {
                bigNeighbour++;
            }
        }
        return bigNeighbour;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int bigNeighbour = FindCountOfGreaterNeighbours(numbers);
        Console.WriteLine(bigNeighbour);
    }
}

