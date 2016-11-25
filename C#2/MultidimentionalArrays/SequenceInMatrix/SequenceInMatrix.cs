using System;

class SequenceInMatrix
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] sizes = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int n = int.Parse(sizes[0]);
        int m = int.Parse(sizes[1]);

        string[,] elements = new string[n, m];

        for (int row = 0; row < n; row++)
        {
            string[] crrRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int col = 0; col < m; col++)
            {
                elements[row, col] = crrRow[col];
            }
        }





        int countEqual = 1;
        int countMax = 0;

        for (int row = 0; row < n; row++)
        {
            for (int col = 1; col < m; col++)
            {
                if (elements[row, col] == elements[row, col - 1])
                {
                    countEqual++;
                }
                if (countEqual > countMax)
                {
                    countMax = countEqual;
                }
                else if (elements[row, col] != elements[row, col - 1])
                {
                    countEqual = 1;
                }
            }
        }

        countEqual = 1;

        for (int col = 0; col < m; col++)
        {
            for (int row = 1; row < n; row++)
            {
                if (elements[row, col] == elements[row - 1, col])
                {
                    countEqual++;
                }
                if (countEqual > countMax)
                {
                    countMax = countEqual;
                }
                else if (elements[row, col] != elements[row - 1, col])
                {
                    countEqual = 1;
                }
            }
        }

        countEqual = 1;
        //Findind max Diagonal left to right
        for (int col = 0; col < elements.GetLength(1) - 1; col++)
        {
            for (int row = elements.GetLength(0) - 1; row >= 0; row--)
            {
                for (int row2 = row, col2 = col; row2 < elements.GetLength(0) - 1 && col2 < elements.GetLength(1) - 1; row2++, col2++)
                {
                    if (elements[row2, col2] == elements[row2 + 1, col2 + 1])
                    {
                        countEqual++;
                        if (countEqual > countMax)
                        {
                            countMax = countEqual;
                          //  maxString = matrix[row2, col2];
                        }
                    }
                }

                countEqual = 1;
            }
        }

        //Findind max Diagonal right to left
        for (int col = elements.GetLength(1) - 1; col >= 0; col--)
        {
            for (int row = elements.GetLength(0) - 1; row >= 0; row--)
            {
                for (int row2 = row, col2 = col; row2 < elements.GetLength(0) - 1 && col2 >= 1; row2++, col2--)
                {
                    if (elements[row2, col2] == elements[row2 + 1, col2 - 1])
                    {
                        countEqual++;
                        if (countEqual > countMax)
                        {
                            countMax = countEqual;
                            //maxString = matrix[row2, col2];
                        }
                    }
                }

                countEqual = 1;
            }
        }

        Console.WriteLine(countMax);
    }
}
