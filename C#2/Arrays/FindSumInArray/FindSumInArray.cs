using System;

class FindSumInArray
{
    static void Main()
    {
        // int[] arr = { 4, 3, 1, 4, 2, 5, 8 };

        //set the lengt of the arra  n + 1 if n is read from the console then assign the values with start index 1
        int[] arr = new int[8];
        arr[1] = 4;
        arr[2] = 3;
        arr[3] = 1;
        arr[4] = 4;
        arr[5] = 2;
        arr[6] = 5;
        arr[7] = 8;

        int s = 11;

        int sum = 0;
        int lastIndex = 0;
        int counter = 0;

        for (int i = 1; i <= arr.Length; i++)
        {
            
            if (sum == s )
            {
                lastIndex = i -1;
                break;
            }

            else if (sum > s)
            {
                i--;
                sum = arr[i];
                counter = 0;
            }
            else
            {
                sum += arr[i];
                lastIndex = i;
                counter++;
            }
        }

        for (int i = lastIndex - counter; i <= lastIndex; i++)
        {
            Console.WriteLine(arr[i]);
        }
        
    }
}

