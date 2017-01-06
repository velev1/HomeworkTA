namespace Divisible_by_7_and_3
{
    using System;
    using System.Linq;
    public class DevisibleBy7and3
    {
        static void Main()
        {
            var array = new int[500];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            var newArray = array.Where(x => x % 3 == 0 && x % 7 == 0);

            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }

            var newArrLinq =
                from x in array
                where x % 7 == 0 && x % 3 == 0
                select x;
            Console.WriteLine("The same thing with linq");
            foreach (var item in newArrLinq)
            {
                Console.WriteLine(item);
            }
        }
    }
}
