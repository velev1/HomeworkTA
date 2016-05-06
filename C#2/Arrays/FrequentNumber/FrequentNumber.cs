using System;

class FrequentNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);

        int crrCount = 1;
        int maxCount = 0;
        int number = 0;
        int tempNumber = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == tempNumber)
            {
                crrCount++;
                if (crrCount > maxCount)
                {
                    maxCount = crrCount;
                    number = arr[i];
                }
            }
            else
            {
                crrCount = 1;
                tempNumber = arr[i];
            }
        }
        Console.WriteLine("{0} ({1} times)", number, maxCount);
    }
}

