namespace MatrixGeneric
{

    using System;
    public class Matrix<T> where T : IComparable<T>
    {
        public int Rows { get; private set; }

        public int Cols { get; private set; }

        T[,] ma3x;

        public T this[int row, int col]
        {
            get
            {
                if ((row > Rows - 1) || (col > Cols - 1) || (row < 0) || (col < 0))
                {
                    throw new IndexOutOfRangeException("The index is outside of the bounds of the matrix.");
                }
                return ma3x[row, col];
            }
            set
            {
                if ((row > Rows - 1) || (col > Cols - 1) || (row < 0) || (col < 0))
                {
                    throw new IndexOutOfRangeException("The index is outside of the bounds of the matrix.");
                }
                ma3x[row, col] = value;
            }
        }

        public Matrix(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            ma3x = new T[Rows, Cols];
        }

        /// <summary>
        /// addition of two matrices 
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if ((m1.Rows != m2.Rows) || (m1.Cols != m2.Cols))
            {
                throw new ArgumentException("The dimentions of the two matrices must be the same");
            }
            else
            {
                var newMatrix = new Matrix<T>(m1.Rows, m1.Cols);
                for (int row = 0; row < m1.Rows; row++)
                {
                    for (int col = 0; col < m1.Cols; col++)
                    {
                        newMatrix[row, col] = (dynamic)m1[row, col] + m2[row, col];
                    }
                }
                return newMatrix;
            }
        }

        /// <summary>
        /// Substraction of two matrices
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if ((m1.Rows != m2.Rows) || (m1.Cols != m2.Cols))
            {
                throw new ArgumentException("The dimentions of the two matrices must be the same");
            }
            else
            {
                var newMatrix = new Matrix<T>(m1.Rows, m1.Cols);
                for (int row = 0; row < m1.Rows; row++)
                {
                    for (int col = 0; col < m1.Cols; col++)
                    {
                        newMatrix[row, col] = (dynamic)m1[row, col] - m2[row, col];
                    }
                }
                return newMatrix;
            }
        }

        /// <summary>
        /// Multiplication between matrix and scalar
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static Matrix<T> operator *(Matrix<T> matrix, T number)
        {
            var newMatrix = new Matrix<T>(matrix.Rows, matrix.Cols);

            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    newMatrix[row, col] = matrix[row, col] * (dynamic)number;
                }
            }
            return newMatrix;
        }

        /// <summary>
        /// matrices  multiplication
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Cols != m2.Rows)
            {
                throw new ArgumentException("The columns of the first matrix must be equal to the rows of the second."); 
            }
            else
            {
                var newMatrix = new Matrix<T>(m1.Rows, m2.Cols);
                T temp = default(T);

                for (int row = 0; row < newMatrix.Rows; row++)
                {
                    for (int col = 0; col < newMatrix.Cols; col++)
                    {
                        for (int i = 0; i < newMatrix.Rows; i++)
                        {

                            temp += (dynamic)m1[row, i] * m2[i, col];
                        }
                        newMatrix[row, col] = temp;
                        temp = default(T);
                    }
                }
                return newMatrix;
            }
        }

        /// <summary>
        /// check if there are zeros in the matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns>true if there are NO zeros and false if there are zero/s</returns>
        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row,col].Equals(0))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// check if there are zeros in the matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns>true if there are NO zeros and false if there are zero/s</returns>
        public static bool operator false(Matrix<T> matrix)
        {

            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col].Equals(0))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
