using System;
using System.Linq;
using System.Collections.Generic;

class NumberAsArray
{
    static void Main()
    {
        string numbersLenght = Console.ReadLine(); //not used in the logic...

        var firstNumber= Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var secondNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        var result = new List<int>();
        int index = 0;
        int tempSum = 0;
        int oneMore = 0;
        while (index <= firstNumber.Count - 1 || index <= secondNumber.Count - 1)
        {
            if (index > firstNumber.Count - 1 && index <= secondNumber.Count - 1)
            {
                tempSum = secondNumber[index] + oneMore;
            }
            else if (index <= firstNumber.Count - 1 && index > secondNumber.Count - 1)
            {
                tempSum = firstNumber[index] + oneMore;
            }
            else
            {
                tempSum = firstNumber[index] + secondNumber[index] + oneMore;
            }

            if (tempSum > 9)
            {
                oneMore = 1;
                tempSum -= 10;
            }
            else
            {
                oneMore = 0;
            }
            result.Add(tempSum);
            tempSum = 0;
            index++;
        }

        if (oneMore > 0)
        {
            result.Add(oneMore);
        }

        Console.WriteLine(string.Join(" ",result));
    }
}

