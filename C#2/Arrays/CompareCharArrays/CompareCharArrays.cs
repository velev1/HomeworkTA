//Write a program that compares two char arrays lexicographically(letter by letter).

//Input

//On the first line you will receive the first char array as a string
//On the second line you will receive the second char array as a string
//Output

//Print< if the first array is lexicographically smaller
//Print> if the second array is lexicographically smaller
//Print = if the arrays are equal
//Constraints

//1 <= size of arrays <= 128
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//hello
//halo	    >

//food
//food      =

using System;

class CompareCharArrays
{
    static void Main()
    {
        string inputOne = Console.ReadLine();
        string inputTwo = Console.ReadLine();

        char[] arrOne = new char[inputOne.Length];
        for (int i = 0; i < arrOne.Length; i++)
        {
            arrOne[i] = Convert.ToChar(inputOne.Substring(i, 1));
        }
        char[] arrTwo = new char[inputTwo.Length];
        for (int i = 0; i < arrTwo.Length; i++)
        {
            arrTwo[i] = Convert.ToChar(inputTwo.Substring(i, 1));
        }

        bool NotEqual = false;

        if (arrOne.Length > arrTwo.Length)
        {
            for (int i = 0; i < arrTwo.Length; i++)
            {
                if (arrOne[i] > arrTwo[i])
                {
                    Console.WriteLine(">");
                    NotEqual = true;
                    break;
                }
                else if (arrOne[i] < arrTwo[i])
                {
                    Console.WriteLine("<");
                    NotEqual = true;
                    break;
                }
            }
            if (!NotEqual)
            {
                Console.WriteLine(">");
            }
        }
        else if (arrOne.Length < arrTwo.Length)
        {
            for (int i = 0; i < arrOne.Length; i++)
            {
                if (arrOne[i] > arrTwo[i])
                {
                    Console.WriteLine(">");
                    NotEqual = true;
                    break;
                }
                else if (arrOne[i] < arrTwo[i])
                {
                    Console.WriteLine("<");
                    NotEqual = true;
                    break;
                }
            }
            if (!NotEqual)
            {
                Console.WriteLine("<");
            }
        }
        else
        {
            for (int i = 0; i < arrOne.Length; i++)
            {
                if (arrOne[i] > arrTwo[i])
                {
                    Console.WriteLine(">");
                    NotEqual = true;
                    break;
                }
                else if (arrOne[i] < arrTwo[i])
                {
                    Console.WriteLine("<");
                    NotEqual = true;
                    break;
                }
            }
            if (!NotEqual)
            {
                Console.WriteLine("=");
            }
        }
    }
}


