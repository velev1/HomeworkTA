//Write a program that reads two integer numbers N and K and an array of N elements from the console.Find the maximal sum of K elements in the array.

//Input

//On the first line you will receive the number N
//On the second line you will receive the number K
//On the next N lines the numbers of the array will be given
//Output

//Print the maximal sum of K elements in the array
//Constraints

//1 <= N <= 1024
//1 <= K <= N
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input      Output
//8
//3
//3
//2
//3             16
//-2
//5
//4
//2
//7

using System;

class MaximalKSum
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(arr);
        int sum = 0;

        for (int i = arr.Length - 1; i >= arr.Length - k; i--)
        {
            sum += arr[i];
        }
        Console.WriteLine(sum);
    }
}
