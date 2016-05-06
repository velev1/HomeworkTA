using System;

class BinarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arrNumbers = new int[n];

        for (int i = 0; i < arrNumbers.Length; i++)
        {
            arrNumbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arrNumbers);

        int x = int.Parse(Console.ReadLine());

        int startIndex = 0;
        int lastIndex = arrNumbers.Length - 1;
        int mid = 0;
        bool find = false; 

        while (startIndex <= lastIndex)
        {
            mid = (startIndex + lastIndex) / 2;
            if (arrNumbers[mid] == x)
            {
                Console.WriteLine(mid);
                find = true;
                break;
            }
            else if (arrNumbers[mid] < x)
            {
                startIndex = mid + 1;
            }
            else
            {
                lastIndex = mid - 1;
            }
        }
        if (!find)
        {
            Console.WriteLine("-1");
        }
    }
}

