using System;
using System.Text;

namespace BinaryShort
{
    class BinaryShort
    {
        static void Main()
        {
            
            short number = short.Parse(Console.ReadLine());
            Console.WriteLine(ShortToBynary(number));
        }

        static string ShortToBynary(short number)
        {
            StringBuilder shortInBin = new StringBuilder(16);

            if (number > 0)
            {
                while (number > 0)
                {
                    byte reminder = (byte)(number % 2);
                    number /= 2;
                    shortInBin.Insert(0, reminder);
                }
                if (shortInBin.Length < 16)
                {
                    shortInBin.Insert(0, "0", 16 - shortInBin.Length);
                }
            }
            else if (number < 0)
            {
                number = (short)((short.MaxValue + 1) + number);
                while (number > 0)
                {
                    byte reminder = (byte)(number % 2);
                    number /= 2;
                    shortInBin.Insert(0, reminder);
                }
                if (shortInBin.Length < 16)
                {
                    shortInBin.Insert(0, '1');
                    shortInBin.Insert(1, "0", 16 - shortInBin.Length);
                }

            }
            else
            {
                shortInBin.Insert(0, "0", 16 - shortInBin.Length);
            }

            return shortInBin.ToString();
        }
    }
}