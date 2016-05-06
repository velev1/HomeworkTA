using System;

class SelectionSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int lastIndex = 0;
        int min = int.MaxValue;
        int minIndex = 0;
        int temp = 0;

        while (lastIndex < arr.Length - 1)
        {

            for (int i = lastIndex; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }
            }
            temp = arr[lastIndex];
            arr[lastIndex] = min;
            arr[minIndex] = temp;
            min = int.MaxValue;

            lastIndex++;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

    }
}

