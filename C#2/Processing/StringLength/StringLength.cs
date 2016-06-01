using System;

class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(input.Replace(@"\", string.Empty).PadRight(20, '*'));
    }
}

