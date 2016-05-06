﻿using System;

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
