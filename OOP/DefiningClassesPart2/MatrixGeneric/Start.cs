//Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
//Implement an indexer this[row, col] to access the inner matrix cells.

//Implement the operators + and - (addition and subtraction of matrices of the same size) and* for matrix multiplication.
//Throw an exception when the operation cannot be performed.
//Implement the true operator (check for non-zero elements).

namespace MatrixGeneric
{
    using System;
    public class Start
    {
        public static void Main()
        {
            var m1 = new Matrix<int>(2, 2);
            var m2 = new Matrix<int>(2, 1);
            //test
            m1[0, 0] = 2;
            m1[0, 1] = 1;
            m1[1, 0] = 1;
            m1[1, 1] = 1;

            m2[0, 0] = 3;
            m2[1, 0] = 3;


            if (m1)
            {
                Console.WriteLine("there are no zeros in this matrix.");
            }
            else
            {
                Console.WriteLine("zero detected");
            }

            //for (int row = 0; row < m1.Rows; row++)
            //{
            //    for (int col = 0; col < m1.Cols; col++)
            //    {
            //        m1[row, col] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int row = 0; row < m2.Rows; row++)
            //{
            //    for (int col = 0; col < m2.Cols; col++)
            //    {
            //        m2[row, col] = int.Parse(Console.ReadLine());
            //    }
            //}


            Console.WriteLine("first matrix-------");
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {
                    Console.Write(" " + m1[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("second matrix--------");
            for (int i = 0; i < m2.Rows; i++)
            {
                for (int j = 0; j < m2.Cols; j++)
                {
                    Console.Write(" " + m2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            var res = m1 * m2;
            Console.WriteLine("The new matrix after multiply ----");
            for (int row = 0; row < res.Rows; row++)
            {
                for (int col = 0; col < res.Cols; col++)
                {
                    Console.Write(" " + res[row, col]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("multiply with scalar ---");
            res = res * 2;
            for (int row = 0; row < res.Rows; row++)
            {
                for (int col = 0; col < res.Cols; col++)
                {
                    Console.Write(" " + res[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}
