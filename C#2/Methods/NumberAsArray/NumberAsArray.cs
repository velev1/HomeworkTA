using System;

class NumberAsArray
{
    static void SumOfnumbersInArray(string[] firstArray, string[] secondArray)
    {


        if (firstArray.Length >= secondArray.Length)
        {
            int[] numbers = new int[firstArray.Length];
            int rem = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (i < secondArray.Length)
                {
                    numbers[i] = Convert.ToInt32(firstArray[i]) + Convert.ToInt32(secondArray[i]) + rem;
                }
                else if (i >= secondArray.Length)
                {
                    numbers[i] = Convert.ToInt32(firstArray[i]);
                }
               if (numbers[i] > 9)
                {
                    numbers[i] = numbers[i] % 10;
                    rem = 1;
                }
                else if (numbers[i] <= 9)
                {
                    rem = 0;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
            
        }

        else
        {
            int[] numbers = new int[secondArray.Length];
            int rem = 0;
            for (int i = 0; i < secondArray.Length; i++)
            {
                if (i < firstArray.Length)
                {
                    numbers[i] = Convert.ToInt32(firstArray[i]) + Convert.ToInt32(secondArray[i]) + rem;
                }
                else if (i >= firstArray.Length)
                {
                    numbers[i] = Convert.ToInt32(secondArray[i]);
                }
                if (numbers[i] > 9)
                {
                    numbers[i] = numbers[i] % 10;
                    rem = 1;
                }
                else if (numbers[i] <= 9)
                {
                    rem = 0;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }

    static void Main()
    {
        string[] sizes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //size of the first array
        int n = Convert.ToInt32(sizes[0]);
        //size of the second array
        int m = Convert.ToInt32(sizes[1]);

        string[] firstArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] secondArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        SumOfnumbersInArray(firstArr, secondArr);

    }
}

