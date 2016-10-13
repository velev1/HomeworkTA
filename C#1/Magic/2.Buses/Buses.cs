using System;

class Buses
{
    static void Main()
    {
        int C = Convert.ToInt32(Console.ReadLine());

        int currGrCount = 0;
        int currSpeed = 0;

        int minSpeed = int.MaxValue;

        for (int i = 0; i < C; i++)
        {
            int S = Convert.ToInt32(Console.ReadLine());

            currSpeed = S;
            if (currSpeed <= minSpeed)
            {
                minSpeed = currSpeed;
                currGrCount++;
            }
        }
        Console.WriteLine(currGrCount);
    }
}

