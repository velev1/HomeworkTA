
namespace DivisibleBy7And3
{
    using System;
    using System.Linq;

    public class DivisibleBy7And3
    {
        public static void Main()
        {
            // fill the array
            int[] arrayOfIntegers = new int[100];

            for (int i = 0; i < 100; i++)
            {
                arrayOfIntegers[i] = i;
            }

            // extension methods and lambda expressions
            var divisibleEXST = arrayOfIntegers.Where(x => x % 3 == 0 && x % 7 == 0);

            Console.WriteLine(string.Join(", ", divisibleEXST));

            // LINQ
            var divisibleLINQ =
                from x in arrayOfIntegers
                where x % 3 == 0 && x % 7 == 0
                select x;

            Console.WriteLine(string.Join(", ", divisibleLINQ));
        }
    }
}
