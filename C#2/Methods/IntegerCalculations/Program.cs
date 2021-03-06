﻿using System;

class IntegerCalculations
{
    static void CalcMinMaxAvgSumProduct(string[] numbers)
    {
        int min = int.MaxValue;
        int max = int.MinValue;
        long sum = 0;
         
        long product = 1L;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (Convert.ToInt32(numbers[i]) > max)
            {
                max = Convert.ToInt32(numbers[i]);
            }
            if (Convert.ToInt32(numbers[i]) < min)
            {
                min = Convert.ToInt32(numbers[i]);
            }
            product *= Convert.ToInt64(numbers[i]);
            sum += Convert.ToInt32(numbers[i]);
        }
        Console.WriteLine(min);
        Console.WriteLine(max);
        double avg = 0;
        if (sum == 0)
        {
            avg = 0;
        }
        else
        {
            avg = sum / 5.0;
        }
        Console.WriteLine("{0:F2}", avg);
        Console.WriteLine(sum);
        Console.WriteLine(product);
    }

    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        CalcMinMaxAvgSumProduct(numbers);
    }
}

