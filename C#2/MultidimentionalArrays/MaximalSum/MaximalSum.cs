using System;

class MaximalSum
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] lenghtOfDementions = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int n = Convert.ToInt32(lenghtOfDementions[0]);
        int m = Convert.ToInt32(lenghtOfDementions[1]);

        int[,] numbers = new int[n, m];

        for (int row = 0; row < numbers.GetLength(0); row++)
        {
            string[] crrRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < numbers.GetLength(1); col++)
            {
                numbers[row, col] = int.Parse(crrRow[col]);
            }
        }

        int sum = 0;
        int maxSum = int.MinValue;

        for (int row = 0; row < numbers.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < numbers.GetLength(1) - 2; col++)
            {
                sum = numbers[row, col] + numbers[row, col + 1] + numbers[row, col + 2]
                    + numbers[row + 1, col] + numbers[row + 1, col + 1] + numbers[row + 1, col + 2]
                    + numbers[row + 2, col] + numbers[row + 2, col + 1] + numbers[row + 2, col + 2];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }
        Console.WriteLine(maxSum);
    }
}

