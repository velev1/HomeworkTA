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
