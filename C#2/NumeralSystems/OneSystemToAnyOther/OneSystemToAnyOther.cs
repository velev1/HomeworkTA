using System;

class OneSystemToAnyOther
{

    static long PowerFun(int number, int power)
    {

        long result = 1;
        if (power == 0)
        {
            return 1L;
        }
        for (int i = 0; i < power; i++)
        {
            result *= number;
        }
        return result;
    }


    static void Main()
    {
        int baseS = int.Parse(Console.ReadLine());
        string number = Console.ReadLine();
        int baseD = int.Parse(Console.ReadLine());

        //COnvert to Dec from base s

        long numberDec = 0;
        int power = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {

            switch (number[i].ToString())
            {
                case "A": numberDec += PowerFun(baseS, power) * 10; power++; break;
                case "B": numberDec += PowerFun(baseS, power) * 11; power++; break;
                case "C": numberDec += PowerFun(baseS, power) * 12; power++; break;
                case "D": numberDec += PowerFun(baseS, power) * 13; power++; break;
                case "E": numberDec += PowerFun(baseS, power) * 14; power++; break;
                case "F": numberDec += PowerFun(baseS, power) * 15; power++; break;
                default:
                    numberDec += PowerFun(baseS, power) * (number[i] - '0'); power++;
                    break;
            }
        }
        //Convert to d from Dec

        string result = "";

        long remainder = 0;

        while (numberDec > 0)
        {
            remainder = numberDec % baseD;


            switch (remainder)
            {
                case 10: numberDec /= baseD; result = "A" + result; break;
                case 11: numberDec /= baseD; result = "B" + result; break;
                case 12: numberDec /= baseD; result = "C" + result; break;
                case 13: numberDec /= baseD; result = "D" + result; break;
                case 14: numberDec /= baseD; result = "E" + result; break;
                case 15: numberDec /= baseD; result = "F" + result; break;
                default:
                    numberDec /= baseD;
                    result = remainder.ToString() + result;
                    break;
            }
        }
        //Print the result
        Console.WriteLine(result);
    }
}

