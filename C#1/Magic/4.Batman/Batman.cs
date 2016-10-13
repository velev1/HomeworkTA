using System;

class Batman
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        char c = '#';
        int mid = n / 2;

        int colRange = 3 * n;
        int rowRange = mid * 3 - 1;

        for (int row = 0; row < rowRange; row++)
        {
            for (int col = 0; col < colRange; col++)
            {
                if (row < mid   && col>=n && col < colRange - n)  // the empty box up
                {
                    Console.Write(" ");
                }
                else if (row == rowRange - 1 && col != colRange/2) // last row
                {
                    Console.Write(" ");
                }
                else if (row > mid -1 && row < rowRange  - mid && col <= mid - 1 ||           // mid
                      row >= mid && row < rowRange - mid && col > colRange  - ((n + 1)/2) )
                {
                    Console.Write(" ");
                }
                else if ((row >= rowRange - mid && row != rowRange - 1) && ((col >= 0) && (col < (colRange - row) / 2)) ||
                         (row >= rowRange - mid && row != rowRange - 1) &&  col > (((colRange - 1) - row) /2)+ row ) 

                  //  row >= rowRange - mid && row!= rowRange - 1 &&
                  //   col>= 0 && col < (colRange - row)/2)   //from mid to bott
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(c);
                }
            }
            Console.WriteLine();
        }
    }
}

