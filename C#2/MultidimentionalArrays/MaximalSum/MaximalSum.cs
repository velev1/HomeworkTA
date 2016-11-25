//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.Print that sum.

//Input

//On the first line you will receive the numbers N and M separated by a single space
//On the next N lines there will be M numbers separated with spaces - the elements of the matrix
//Output

//Print the maximal sum of 3 x 3 square
//Constraints

//3 <= N, M <= 1024
//Numbers in the matrix will be in the interval[-1000, 1000]
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input                 Output
//3 3
//4 3 5
//2 6 4
//8 2 7	                41

//5 5
//1 1 3 3 5
//-6 -7 2 -3 -1
//3 0 -4 5 9
//7 -7 0 1 0
//-7 -6 -4 -4 9	        19

using System;

class MaximalSum
{
    static void Main()
    {
        //dimentions of the sub matrix 
        const int XdimentionLenght = 3; // cols
        const int YdimentionLenght = 3; // rows 

        string[] dimentions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int rows = int.Parse(dimentions[0]);
        int cols = int.Parse(dimentions[1]);
        int[,] matrix =  new int[rows, cols];


        for (int row  = 0; row < rows; row++)
        {
            string[] crrRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = int.Parse(crrRow[col]); 
            }
        }
        
        int sum = 0;
        int maxSum = int.MinValue;
        for (int row = 0; row <= rows - YdimentionLenght; row++)
        {
            for (int col = 0; col <= cols - XdimentionLenght; col++)
            {
                for (int i = 0; i < YdimentionLenght; i++)
                {
                    for (int j = 0; j < XdimentionLenght; j++)
                    {
                        sum += matrix[row + i, col + j];
                    }
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                sum = 0;
            }
        }
        Console.WriteLine(maxSum);
    }
}



//using System;

//class MaximalSum
//{
//    static void Main()
//    {
//        string input = Console.ReadLine();

//        string[] lenghtOfDementions = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//        int n = Convert.ToInt32(lenghtOfDementions[0]);
//        int m = Convert.ToInt32(lenghtOfDementions[1]);

//        int[,] numbers = new int[n, m];

//        for (int row = 0; row < numbers.GetLength(0); row++)
//        {
//            string[] crrRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//            for (int col = 0; col < numbers.GetLength(1); col++)
//            {
//                numbers[row, col] = int.Parse(crrRow[col]);
//            }
//        }

//        int sum = 0;
//        int maxSum = int.MinValue;

//        for (int row = 0; row < numbers.GetLength(0) - 2; row++)
//        {
//            for (int col = 0; col < numbers.GetLength(1) - 2; col++)
//            {
//                sum = numbers[row, col] + numbers[row, col + 1] + numbers[row, col + 2]
//                    + numbers[row + 1, col] + numbers[row + 1, col + 1] + numbers[row + 1, col + 2]
//                    + numbers[row + 2, col] + numbers[row + 2, col + 1] + numbers[row + 2, col + 2];
//                if (sum > maxSum)
//                {
//                    maxSum = sum;
//                }
//            }
//        }
//        Console.WriteLine(maxSum);
//    }
//}

