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


