using System;

class RemoveToSort
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        int[] maxSubsequence = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            maxSubsequence[i] = 1;
        }

        for (int i = 1; i < numbers.Length; i++)
        {

            for (int j = 0; j < i; j++)
            {
                if (numbers[i] >= numbers[j])
                {
                    if (maxSubsequence[j] + 1 > maxSubsequence[i])
                    {
                        maxSubsequence[i] = maxSubsequence[j] + 1;

                    }
                }
            }
        }


        int max = maxSubsequence[0];
        for (int i = 1; i < maxSubsequence.Length; i++)
        {
            if (maxSubsequence[i] > max)
            {
                max = maxSubsequence[i];
            }
        }

        // Console.WriteLine("max = "+max);
        // Console.WriteLine("items to remove: "+ (numbers.Length - max));

        Console.WriteLine(numbers.Length - max);

    }
}

