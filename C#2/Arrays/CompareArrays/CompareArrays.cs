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

