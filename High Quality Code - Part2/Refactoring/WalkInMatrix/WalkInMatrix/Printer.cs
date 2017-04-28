namespace WalkInMatrix
{
    using Contracts;

    public class Printer
    {
        public Printer(IWriter writer)
        {
            this.Use = writer;
        }

        public IWriter Use { get; private set; }

        public void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    this.Use.Write("  " + matrix[i, j]);
                }
                this.Use.WriteLine("");
            }
        }
    }
}
