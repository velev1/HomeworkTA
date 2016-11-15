//Write a program that reads two integer arrays of size N from the console and compares them element by element.

//Input

//On the first line you will receive the number N
//On the next N lines the numbers of the first array will be given
//On the next N lines the numbers of the second array will be given
//Output

//Print Equal if the two arrays are the same and Not equal if they are not
//Constraints

//1 <= N <= 20
//N will always be a valid integer number
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input     Output
//3
//1
//2
//3
//1
//2
//3	        Equal

//3
//1
//1
//1
//2
//2
//2	        Not equal

using System;

class CompareArrays
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arrOne = new int[n];
        int[] arrTwo = new int[n];

        for (int i = 0; i < n; i++)
        {
            arrOne[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            arrTwo[i] = Convert.ToInt32(Console.ReadLine());
        }

        bool checkIfNotEq = false;
        for (int i = 0; i < n; i++)
        {
            if (arrOne[i] != arrTwo[i])
            {
                Console.WriteLine("Not equal");
                checkIfNotEq = true;
                break;
            }
        }

        if (checkIfNotEq == false)
        {
            Console.WriteLine("Equal");
        }
    }
}

