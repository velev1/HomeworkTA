using System;

class Bobi555
{
    static void Main()
    {
        long n = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        string strNum = Convert.ToString(n, 2).PadLeft(32, '0');

        int counterDeff = 0;
        int maxCount = 0;
        long res = 0;

        for (int j = 0; j < c; j++)
        {
            long crrNumber = Convert.ToInt64(Console.ReadLine());
            string strC = Convert.ToString(crrNumber, 2).PadLeft(32, '0');
            counterDeff = 0;
            for (int i = 0; i < strNum.Length; i++)
            {

                if (strNum[i] != strC[i])
                {
                    counterDeff++;
                    if (counterDeff > maxCount)
                    {
                        maxCount = counterDeff;
                        res = crrNumber;
                    }
                }
            }
        }
        Console.WriteLine(res);
    }
}

