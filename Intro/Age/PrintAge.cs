using System;

class PrintAge
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        string dateFormat = "MM'.'dd'.'yyyy";
        string input = (Console.ReadLine());
        DateTime birthDate = DateTime.ParseExact(input, dateFormat, null); 
        ushort age = (ushort)((today - birthDate).TotalDays / 365.25);
        Console.WriteLine(age);
        Console.WriteLine(age + 10);
    }
}

