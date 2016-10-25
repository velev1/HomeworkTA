//Write a program first reads 4 numbers n, p, q and k and than swaps bits { p, p+1, …, p+k-1}
//with bits { q, q+1, …, q+k-1}
//of n.Print the resulting integer on the console.
//Input
//On the only four lines of the input you will receive the integers n, p, q and k in this order.
//Output
//Output a single value - the value of n after the bit swaps.
//Constraints
//The first and the second sequence of bits will never overlap.
//n will always be a valid 32-bit positive integer.
//p, q >= 0
//p+k-1, q+k-1 < 32
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input         Binary representation                       Binary representation after swaps       Output
//1140867093
//3
//24
//3	            01000100 00000000 01000000 00010101	        01000010 00000000 01000000 00100101	    1107312677

//4294901775
//24
//3
//3	            11111111 11111111 00000000 00001111	        11111001 11111111 00000000 00111111	    4194238527

//2369124121
//2
//22
//10	        10001101 00110101 11110111 00011001	        01110001 10110101 11111000 11010001	    1907751121

using System;

class BitSwap
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine()); //step k

        uint firstBit = (uint)1 << p;
        uint firstMask = firstBit;

        //Generates the size of the mask. How meny bits are in it. The result is stored in firstBit.
        for (int i = 0; i < k - 1; i++)
        {
            firstMask <<= 1;
            firstBit |= firstMask;
        }
        //test
        //Console.WriteLine(firstBit);
        //firstBit >>= p;
        //Console.WriteLine(firstBit);

        firstBit &= number;
        uint eraser = ~firstBit;
        number &= eraser;
        firstBit >>= p; //p positions shift

        uint secondBit = (uint)1 << q;
        uint secondMask = secondBit;
        for (int i = 0; i < k - 1; i++)
        {
            secondMask <<= 1;
            secondBit |= secondMask;
        }
        secondBit &= number;
        eraser = ~secondBit;
        number &= eraser;
        secondBit >>= q; //q positions shift
        //swap the bits
        firstBit <<= q;
        secondBit <<= p;
        number |= firstBit;
        number |= secondBit;
        Console.WriteLine(number);
    }
}
