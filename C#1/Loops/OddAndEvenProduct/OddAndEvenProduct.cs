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

