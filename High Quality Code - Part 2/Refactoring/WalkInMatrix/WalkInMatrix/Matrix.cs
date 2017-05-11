namespace WalkInMatrix
{
    using System;

    using Contracts;

    public class Matrix : IMatrix
    {
        public int[,] FillMatrix(int n)
        {
            if (n < 2)
            {
                throw new ArgumentException("The minimum number for matrix dimention is 2");
            }

            var matrix = new int[n, n];

            string direction = "DownRight";

            int row = 0;
            int col = 0;
            int[] matrixIndex = new int[2];

            for (int i = 1; i <= matrix.Length; i++)
            {
                bool inMatrix = false;

                inMatrix = CheckIsInMatrix(row, col, n);
                string previousDirection = "";
                while (!inMatrix)
                {
                    previousDirection = direction;
                    direction = UpdateDirection(direction);

                    matrixIndex = RevertIndex(row, col, previousDirection);
                    row = matrixIndex[0];
                    col = matrixIndex[1];

                    matrixIndex = UpdateIndex(row, col, direction);
                    row = matrixIndex[0];
                    col = matrixIndex[1];

                    inMatrix = CheckIsInMatrix(row, col, n);

                    if (inMatrix && matrix[row, col] == 0)
                    {
                        break;
                    }
                }

                while (inMatrix && matrix[row, col] != 0)
                {

                    bool foundWay = false;

                    for (int j = 0; j < 7; j++)
                    {
                        previousDirection = direction;
                        direction = UpdateDirection(direction);

                        matrixIndex = RevertIndex(row, col, previousDirection);
                        row = matrixIndex[0];
                        col = matrixIndex[1];

                        matrixIndex = UpdateIndex(row, col, direction);
                        row = matrixIndex[0];
                        col = matrixIndex[1];

                        if (matrix[row, col] == 0)
                        {
                            foundWay = true;
                            break;
                        }

                        if (j == 6 && !foundWay)
                        {
                            matrixIndex = FindFreeCell(matrix);
                            row = matrixIndex[0];
                            col = matrixIndex[1];
                            direction = "DownRight";
                        }
                    }
                }


                matrix[row, col] = i;


                matrixIndex = UpdateIndex(row, col, direction);
                row = matrixIndex[0];
                col = matrixIndex[1];
            }

            return matrix;
        }


        protected static int[] FindFreeCell(int[,] matrix)
        {

            if (matrix == null)
            {
                throw new ArgumentNullException("The collection cannot be null.");
            }

            int row = 0;
            int col = 0;
            bool foundFreeCell = false;

            for (row = 0; row < matrix.GetLength(0); row++)
            {
                for (col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        foundFreeCell = true;
                        break;
                    }
                }

                if (foundFreeCell)
                {
                    break;
                }
            }

            if (foundFreeCell)
            {
                int[] cellNumber = { row, col };
                return cellNumber;
            }

            throw new ArgumentException(
                "free cell not found chek if method is invoked unessesary e.g all elements of the matrix != 0");
        }

        private static int[] RevertIndex(int row, int col, string previousDirection)
        {
            switch (previousDirection)
            {
                case "DownRight":
                    row--;
                    col--;
                    break;
                case "Down":
                    row--;
                    break;
                case "DownLeft":
                    row--;
                    col++;
                    break;
                case "Left":
                    col++;
                    break;
                case "UpLeft":
                    row++;
                    col++;
                    break;
                case "Up":
                    row++;
                    break;
                case "UpRight":
                    row++;
                    col--;
                    break;
                case "Right":
                    col--;
                    break;
            }

            int[] matrix = { row, col };

            return matrix;
        }

        private static string UpdateDirection(string direction)
        {
            string[] directions = { "DownRight", "Down", "DownLeft", "Left", "UpLeft", "Up", "UpRight", "Right" };

            int currentIndex = Array.IndexOf(directions, direction);

            currentIndex++;
            if (currentIndex > directions.Length - 1)
            {
                currentIndex = 0;
            }

            return directions[currentIndex];
        }

        private static bool CheckIsInMatrix(int row, int col, int n)
        {
            if (row >= n || row < 0 || col >= n || col < 0)
            {
                return false;
            }

            return true;
        }

        private static int[] UpdateIndex(int row, int col, string direction)
        {
            switch (direction)
            {
                case "DownRight":
                    row++;
                    col++;
                    break;
                case "Down":
                    row++;
                    break;
                case "DownLeft":
                    row++;
                    col--;
                    break;
                case "Left":
                    col--;
                    break;
                case "UpLeft":
                    row--;
                    col--;
                    break;
                case "Up":
                    row--; break;
                case "UpRight":
                    row--;
                    col++;
                    break;
                case "Right":
                    col++;
                    break;
            }

            int[] matrix = { row, col };

            return matrix;
        }
    }
}
