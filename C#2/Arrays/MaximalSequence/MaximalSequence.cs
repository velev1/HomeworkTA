//Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.

//Input

//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//Output

//Print the length of the maximal sequence
//Constraints

//1 <= N <= 1024
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input     Output
//10
//2
//1
//1
//2
//3
//3
//2
//2
//2
//1	            3


using System;

class MaximalSequence
{
    static void Main()
    {
         int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        int range = 1;
        int maxRange = 0;
        int temp = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == temp)
            {
                range++;
                if (range > maxRange)
                {
                    maxRange = range;
                }
            }
            else
            {
                range = 1;
            }
            temp = arr[i];
        }
        Console.WriteLine(maxRange);
    }
}

