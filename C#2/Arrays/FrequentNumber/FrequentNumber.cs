//Write a program that finds the most frequent number in an array of N elements.

//Input

//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//Output

//Print the most frequent number and how many time it is repeated
//Output should be REPEATING_NUMBER(REPEATED_TIMES times)
//Constraints

//1 <= N <= 1024
//0 <= each number in the array <= 10000
//There will be only one most frequent number
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input      Output
//13
//4
//1
//1
//4
//2
//3
//4
//4
//1
//2
//4
//9
//3	         4 (5 times)

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

