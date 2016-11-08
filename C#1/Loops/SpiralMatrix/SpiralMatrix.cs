//Write a program that reads from the console a positive integer number N(1 ≤ N ≤ 20) and 
//prints a matrix holding the numbers from 1 to N* N in the form of square spiral like in the examples below.
//Input
//The input will always consist of a single line containing a single number - N.
//Output
//Output a spiral matrix as described below.
//Constraints
//N will always be a valid integer number.
//1 ≤ N ≤ 20
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input     Output
//2	        1 2
//          4 3

//3	        1 2 3
//          8 9 4
//          7 6 5

//4	        1 2 3 4
//          12 13 14 5
//          11 16 15 6
//          10 9 8 7

using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
       
        int[,] matrix = new int[n,n];
        int row = 0;
        int col = 0;
        string direction = "R";

        for (int i = 1; i <= matrix.Length; i++ )
        {
            //chek for current directin and if row or col is outside of the arr demention 
            //and chek for that values of row and col if there is existing element in the array 
            //with value different of zero. (zero is the default value)
            //correct the values of the row and col
            if (direction == "R" && (col==n || matrix[row,col] != 0))
            {
                direction = "D";
                col--;
                row++;
            }
            else if (direction == "D" && (row ==n || matrix[row,col] != 0))
            {
                direction = "L";
                col--;
                row--;
            }
            else if (direction == "L" && (col<0 || matrix[row,col] != 0))
            {
                direction = "U";
                row--;
                col++;
            }
            else if (direction == "U" && (row < 0 || matrix[row,col] !=0))
            {
                direction = "R";
                row++;
                col++;
            }
            //set the value of  matrix[row,col] 
            matrix[row, col] = i;

            //set row or col by direction
            switch (direction)
            {
                case "R": col++; break;
                case "L": col--; break;
                case "D": row++; break;
                case "U": row--; break;
            }
        }
        //print the matrix
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0} ",matrix[i,j]);
            }
            Console.WriteLine();
        }
    }
}

