using System;

class IntDoubleString
{
    static void Main()
    {
        string input = Console.ReadLine();

        switch (input)
        {
            case "integer":
                int intNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(intNumber + 1);
                break;

            case "real": 
                double realNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("{0:F2}",realNumber + 1);
                break;

            case "text":
                string str = Console.ReadLine();
                Console.WriteLine(str+"*");
                break; 

            default:
                break;
        }
    }
}

