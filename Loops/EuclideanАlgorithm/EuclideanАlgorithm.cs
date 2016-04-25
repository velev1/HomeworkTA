using System;

class EuclideanАlgorithm
{
    static void Main()
    {
        string numbers = Console.ReadLine();

        string[] arrNums = numbers.Split(' ');

        int firstNumber = 0;
        int secondNumber = 0;
        int counter = 0;

        for (int i = 0; i < arrNums.Length; i++)
        {
            if (arrNums[i] != string.Empty)
            {
                if (counter == 0)
                {
                    firstNumber = Convert.ToInt32(arrNums[i].ToString());
                    counter++;
                }
                else
                {
                    secondNumber = Convert.ToInt32(arrNums[i].ToString());
                    counter++;
                }
            }
        }
        int max = Math.Max(firstNumber, secondNumber);
        int min = Math.Min(firstNumber, secondNumber);
        int remainder = 1;
        while (remainder > 0)
        {
            remainder = max % min;
            max = min;
            min = remainder;
        }
        Console.WriteLine(max);
    }
}
