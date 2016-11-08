﻿//You are given N integers(given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to N, so the first element is odd, the second is even, etc.
//Input
//On the first line you will receive the number N
//On the second line you will receive N numbers separated by a whitespace
//Output
//If the two products are equal, output a string in the format "yes PRODUCT_VALUE", otherwise write on the console "no ODD_PRODUCT_VALUE EVEN_PRODUCT_VALUE"
//Constraints
//N will always be a valid integer number in the range [4, 50]
//All input numbers from the second line will also be valid integers
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input         Output
//5
//2 1 1 6 3	    yes 6

//5
//4 3 2 5 2	    no 16 15

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string numbers = Console.ReadLine();

        string[] arrNums = numbers.Split(' ');
        int counter = 1;
        long productOdd = 1;
        long productEven = 1;
        
        for (int i = 0; i < arrNums.Length; i++)
        {
            if (arrNums[i] != String.Empty)
            {
                if (counter % 2 != 0)
                {
                    productOdd *= Convert.ToInt32(arrNums[i]);
                    counter++;
                }
                else
                {
                    productEven *= Convert.ToInt32(arrNums[i]);
                    counter++;
                }
            }
        }
        if (productOdd == productEven)
        {
            Console.WriteLine("yes {0}",productOdd);
        }
        else
        {
            Console.WriteLine("no {0} {1}",productOdd,productEven);
        }
    }
}

