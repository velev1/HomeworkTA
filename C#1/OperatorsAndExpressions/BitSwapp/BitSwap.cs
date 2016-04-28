using System;

class BitSwap
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        string kBinString = "1";
        for (int i = 1; i < k; i++)
        {
            kBinString = kBinString + "1";
        }
        int kInt = Convert.ToInt32(kBinString, 2);

        long shortBits = number >> p;
        long numberShortBits = shortBits & kInt;

        long longBits = number >> q;
        long numberLongBits = longBits & kInt;

        long maskOne = ~(kInt << q);
        long shortAtLongChanger = numberShortBits << q;
        long resultOne = (number & maskOne) | shortAtLongChanger;

        long maskTwo = ~(kInt << p);
        long LongAtShortChanger = numberLongBits << p;
        long resultTwo = (resultOne & maskTwo) | LongAtShortChanger;

        Console.WriteLine(resultTwo);
    }
}
