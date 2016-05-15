using System;

class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string method = Console.ReadLine();
        int[,] matrix = new int[n, n];

        int counter = 0;

        if (method == "a")
        {
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    counter++;
                    matrix[row, col] = counter;
                }
            }
        }

        else if (method == "b")
        {
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        counter++;
                        matrix[row, col] = counter;
                    }
                }
                else if (col % 2 != 0)
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        counter++;
                        matrix[row, col] = counter;
                    }
                }
            }
        }

        else if (method == "c")
        {
            int number = 1;

            for (int col = 0; col < n; col++)
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    for (int row2 = row, col2 = col; row2 < n && col2 < n; row2++, col2++)
                    {
                        if (matrix[row2, col2] == 0)
                        {
                            matrix[row2, col2] = number;
                            number++;
                        }
                    }
                }
            }
        }
        else if (method == "d")
        {
            string direction = "down";
            int row = 0;
            int col = 0;

            for (int i = 1; i <= matrix.Length; i++)
            {
                if (direction == "down" && (row == n || matrix[row, col] != 0))
                {
                    direction = "right";
                    row--;
                    col++;
                }
                else if (direction == "right" && (col == n || matrix[row, col] != 0))
                {
                    direction = "up";
                    col--;
                    row--;
                }
                else if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row++;
                    col--;
                }
                else if (direction == "left" && (matrix[row, col] != 0))
                {
                    direction = "down";
                    col++;
                    row++;
                }

                matrix[row, col] = i;

                switch (direction)
                {
                    case "down": row++; break;
                    case "right": col++; break;
                    case "up": row--; break;
                    case "left": col--; break;
                }
            }
        }



        //print
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0}", matrix[row, col]);
                if (col < n - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

    }
}

