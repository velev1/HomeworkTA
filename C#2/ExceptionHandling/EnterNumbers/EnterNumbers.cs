using System;

class EnterNumbers
{
    static void Main()
    {
        try
        {
            //int start = int.Parse(Console.ReadLine());
            //int end = int.Parse(Console.ReadLine());
            ReadNumber(1, 100);
        }
        catch (FormatException)
        {
            Console.WriteLine("Exception");
        }
    }

    static void ReadNumber(int start, int end)
    {
        var numbers = new int[12];
        numbers[0] = start;
        numbers[11] = end;
        bool test = false;

        for (int i = 1; i < numbers.Length - 1; i++)
        {
            try
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] < numbers[i - 1])
                {
                    Console.WriteLine("Exception");
                    test = true;
                    break;
                }
                else if (i == numbers.Length - 2 && numbers[i] > numbers[i + 1])
                {
                    Console.WriteLine("Exception");
                    test = true;
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Exception");
                test = true;
                break;
            }
        }
        if (!test)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < numbers.Length -1)
                {
                    Console.Write("{0} < ", numbers[i]);
                }
                else if ( i == numbers.Length - 1)
                {
                    Console.Write(numbers[i]);
                }
            }
        }
    }
}

