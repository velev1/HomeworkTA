//description
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/homework/08.%20Catalan%20Numbers

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        
        if (n == 0)
        {
            Console.WriteLine(1);
        }
        else
        {
            var firstPart = new BigInteger(1);
            var secondPart = new BigInteger(n);

            int range = 2 * n - (n + 1);
            int temp = 2 * n;

            for (int i = range; i > 0; i--)
            {
                firstPart *= temp;
                temp--;
                if (n > 0)
                {
                    n--;
                    secondPart *= n;
                }
            }
            Console.WriteLine(firstPart / secondPart);
        }

        
    }
}

