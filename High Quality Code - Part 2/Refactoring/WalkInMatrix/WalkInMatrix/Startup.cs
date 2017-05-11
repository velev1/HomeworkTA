namespace WalkInMatrix
{
    public class Startup
    {
        public static void Main()
        {
            var reader = new Reader();
            var inputReader = new InputReader(reader);

            int n = int.Parse(inputReader.Use.ReadLine());

            Matrix m = new Matrix();

            var matrix = m.FillMatrix(n);
           
            var writer = new Writer();
            var printer = new Printer(writer);

            printer.PrintMatrix(matrix);
        }
    }
}
