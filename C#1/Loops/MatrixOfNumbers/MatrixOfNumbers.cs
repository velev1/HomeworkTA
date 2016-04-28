using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("{0} ",j + i);
            }
            Console.WriteLine();
        }
    }
}
