
namespace Matrixes
{
    using System;
    class Program
    {
        static void Main()
        {
            int row = 3, col = 3;

            var firstMatrix = new Matrix<int>(row,col);

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    firstMatrix[r, c] = r + c + 1;
                }
            }

            row = 3;
            col = 3;
            var secindMatrix = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    secindMatrix[r, c] = r + c + 10;
                }
            }
            Console.WriteLine(firstMatrix);
            Console.WriteLine(secindMatrix);

            Console.WriteLine(firstMatrix + secindMatrix);
            Console.WriteLine(secindMatrix - firstMatrix);
            Console.WriteLine(firstMatrix * secindMatrix);

            if (firstMatrix)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
