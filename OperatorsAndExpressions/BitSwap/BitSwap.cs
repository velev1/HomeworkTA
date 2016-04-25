using System;

class BitSwap
{
    static void Main()
    {
        uint number = Convert.ToUInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        int q = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());
        
        uint bit;
        string[] arrBits = new string[32];
        int i = 0;
        while (number>0)
        {
            bit = number % 2;
            number = number / 2;
            arrBits[i] = bit.ToString();
            i++;
        }
        string binNumber="";
        string[] arrBits2 = new string[32];
        int j = 0;
        for (int index = 31; index >= 0; index--)
        {
           // Console.Write(arrBits[index]);
            arrBits2[j] = arrBits[index];
            j++;
        }
        string buffer;
        int max = Math.Max(((p + (k - 1)) - (p + 1)), ((q + (k - 1)) - q + 1));
        int min = Math.Min(((p + (k - 1)) - (p + 1)), ((q + (k - 1)) - q + 1));
        int lenght = max - min;
        int counterP = p + 1;
        int counterQ = q + 1;
        for (int index = 0; index <= lenght; index++)
        {
            buffer = arrBits2[counterP];
            arrBits2[counterP] = arrBits2[counterQ];
            arrBits2[counterQ] = buffer;
            counterP++;
            counterQ++;
        }
        for (int index = 0; index < arrBits2.Length; index++)
        {
            binNumber += arrBits2[index];
        }
        Console.WriteLine(Convert.ToUInt32(binNumber, 2).ToString());
    }
}

