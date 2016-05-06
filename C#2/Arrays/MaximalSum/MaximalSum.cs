//Maximal sum

//Write a program that finds the sequence of maximal sum in given array.
//Example:

//input result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8	2, -1, 6, 4
//Can you do it with only one loop (with single scan through the elements of the array)?




using System;

class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int crrSum = 0;
        int maxSum = 0;
        int tempStart = 0;
        int startIndex = 0;
        int lastIndex = 0;


        for (int i = 0; i < arr.Length; i++)
        {
            
            if (crrSum < 0)
            {
                tempStart = i;
                crrSum = arr[i];
            }
            else
            {
                crrSum += arr[i];
            }

            if (crrSum > maxSum)
            {
                maxSum = crrSum;
                lastIndex = i;
                startIndex = tempStart;
            }
        }
        Console.WriteLine(maxSum);
        //for (int i = startIndex; i <= lastIndex; i++)
        //{
        //    Console.WriteLine(arr[i]);
        //}
    }
}

