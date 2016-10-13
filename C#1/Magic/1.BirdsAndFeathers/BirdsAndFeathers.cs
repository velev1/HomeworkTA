using System;

class BirdsAndFeathers
{
    static void Main()
    {
        int B = Convert.ToInt32(Console.ReadLine());
        int F = Convert.ToInt32(Console.ReadLine());

        double avg = F / (double)B;
        double result = 0.0;

        if (B == 0)
        {
            avg = 0.0;
        }
        if (B %2 ==0)
        {
            result = avg * 123123123123;
        }
        else
        {
            result = avg / 317;
        }
        Console.WriteLine("{0:F4}",result);
    }
}

