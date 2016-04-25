using System;

class MMSAofnNumbers
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        double number;
        double min = double.MaxValue;
        double max = double.MinValue;
        double sum = 0;
        double avg;

        for (int i = 0; i < n; i++)
        {
            number = Convert.ToDouble(Console.ReadLine());

            sum += number;
            if (min > number)
            {
                min = number;
            }
            if (max < number)
            {
                max = number;
            }
        }
        avg = sum / n;
        Console.WriteLine("min={0:F2}",min);
        Console.WriteLine("max={0:F2}",max);
        Console.WriteLine("sum={0:F2}",sum);
        Console.WriteLine("avg={0:F2}",avg);
    }
}

