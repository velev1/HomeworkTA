namespace CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    public class CompareSimpleMathTest
    {
        private const int TIMES_TO_INVOKE = 10000000;
        private const int SYMBOLS_COUNT_TIME = 16;
        private const int SYMBOLS_COUNT_MSG = 29;

        public static void Main()
        {
            MisureTimeSum();

            Console.WriteLine("----------------------------------------------");

            MisureTimeSubtract();

            Console.WriteLine("----------------------------------------------");

            MisureTimeIncrement();

            Console.WriteLine("----------------------------------------------");

            MisureTimeMultiply();

            Console.WriteLine("----------------------------------------------");

            MisureTimeDivide();
        }

        private static void MisureTimeDivide()
        {
            MisureDivideWithInts();
            MisureDivideWithLongs();
            MisureDivideWithFloats();
            MisureDivideWithDoubles();
            MisureDivideWithDecimals();
        }

        private static void MisureTimeMultiply()
        {
            MisureMultiplyWithInts();
            MisureMultiplyWithLongs();
            MisureMultiplyWithFloats();
            MisureMultiplyWithDoubles();
            MisureMultiplyWithDecimals();
        }

        private static void MisureTimeSum()
        {
            MisureSumWithInts();
            MisureSumWithLongs();
            MisureSumWithFloats();
            MisureSumWithDoubles();
            MisureSumWithDecimals();
        }

        private static void MisureTimeSubtract()
        {
            MisureSubtractWithInts();
            MisureSubtractWithLongs();
            MisureSubtractWithFloats();
            MisureSubtractWithDoubles();
            MisureSubtractWithDecimals();
        }

        private static void MisureTimeIncrement()
        {
            MisureIncrementWithInts();
            MisureIncrementWithLongs();
            MisureIncrementWithFloats();
            MisureIncrementWithDoubles();
            MisureIncrementWithDecimals();
        }

        private static void MisureDivideWithInts()
        {
            var simpleMath = new MathUtils<int>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Divide(10, 10);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Divide with ints time:",
                    sw.Elapsed));
        }

        private static void MisureDivideWithLongs()
        {
            var simpleMath = new MathUtils<long>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Divide(10L, 10L);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Divide with longs time:",
                    sw.Elapsed));
        }

        private static void MisureDivideWithFloats()
        {
            var simpleMath = new MathUtils<float>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Divide(10f, 10f);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Divide with floats time:", 
                    sw.Elapsed));
        }

        private static void MisureDivideWithDoubles()
        {
            var simpleMath = new MathUtils<double>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Divide(10d, 10d);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Divide with doubles time:",
                    sw.Elapsed));
        }

        private static void MisureDivideWithDecimals()
        {
            var simpleMath = new MathUtils<decimal>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Divide(10m, 10m);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Divide with decimals time:",
                    sw.Elapsed));
        }

        private static void MisureMultiplyWithInts()
        {
            var simpleMath = new MathUtils<int>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Multiply(10, 10);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Multiply with ints time:",
                    sw.Elapsed));
        }

        private static void MisureMultiplyWithLongs()
        {
            var simpleMath = new MathUtils<long>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Multiply(10L, 10L);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Multiply with longs time:",
                    sw.Elapsed));
        }

        private static void MisureMultiplyWithFloats()
        {
            var simpleMath = new MathUtils<float>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Multiply(10f, 10f);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Multiply with floats time:",
                    sw.Elapsed));
        }

        private static void MisureMultiplyWithDoubles()
        {
            var simpleMath = new MathUtils<double>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Multiply(10d, 10d);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Multiply with doubles time:",
                    sw.Elapsed));
        }

        private static void MisureMultiplyWithDecimals()
        {
            var simpleMath = new MathUtils<decimal>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Multiply(10m, 10m);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Multiply with decimals time:",
                    sw.Elapsed));
        }

        private static void MisureIncrementWithInts()
        {
            var simpleMath = new MathUtils<int>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Increment(10);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Increment with ints time:",
                    sw.Elapsed));
        }

        private static void MisureIncrementWithLongs()
        {
            var simpleMath = new MathUtils<long>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Increment(10L);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Increment longs time:",
                    sw.Elapsed));
        }

        private static void MisureIncrementWithFloats()
        {
            var simpleMath = new MathUtils<float>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Increment(10f);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Increment with floats time:",
                    sw.Elapsed));
        }

        private static void MisureIncrementWithDoubles()
        {
            var simpleMath = new MathUtils<double>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Increment(10d);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Increment with doubles time:",
                    sw.Elapsed));
        }

        private static void MisureIncrementWithDecimals()
        {
            var simpleMath = new MathUtils<decimal>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Increment(10m);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Increment with decimals time:",
                    sw.Elapsed));
        }

        private static void MisureSubtractWithInts()
        {
            var simpleMath = new MathUtils<int>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Subtract(10, 10);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Subtract with ints time:",
                    sw.Elapsed));
        }

        private static void MisureSubtractWithLongs()
        {
            var simpleMath = new MathUtils<long>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Subtract(10L, 10L);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Subtract with longs time:", 
                    sw.Elapsed));
        }

        private static void MisureSubtractWithFloats()
        {
            var simpleMath = new MathUtils<float>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Subtract(10f, 10f);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Subtract with floats time:",
                    sw.Elapsed));
        }

        private static void MisureSubtractWithDoubles()
        {
            var simpleMath = new MathUtils<double>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Subtract(10d, 10d);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Subtract with doubles time:",
                    sw.Elapsed));
        }

        private static void MisureSubtractWithDecimals()
        {
            var simpleMath = new MathUtils<decimal>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Subtract(10m, 10m);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Subtract with decimals time:",
                    sw.Elapsed));
        }

        private static void MisureSumWithInts()
        {
            var simpleMath = new MathUtils<int>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Sum(10, 10);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Sum with ints time:",
                    sw.Elapsed));
        }

        private static void MisureSumWithLongs()
        {
            var simpleMath = new MathUtils<long>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Sum(10L, 10L);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Sum with longs time:",
                    sw.Elapsed));
        }

        private static void MisureSumWithFloats()
        {
            var simpleMath = new MathUtils<float>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Sum(10f, 10f);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Sum with floats time:",
                    sw.Elapsed));
        }

        private static void MisureSumWithDoubles()
        {
            var simpleMath = new MathUtils<double>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Sum(10d, 10d);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Sum with doubles time:", 
                    sw.Elapsed));
        }

        private static void MisureSumWithDecimals()
        {
            var simpleMath = new MathUtils<decimal>();

            var sw = Stopwatch.StartNew();
            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                simpleMath.Sum(10m, 10m);
            }

            sw.Stop();

            Console.WriteLine(
                string.Format(
                    "{0," + SYMBOLS_COUNT_MSG + "} {1," + SYMBOLS_COUNT_TIME + "}",
                    "Sum with decimals time:",
                    sw.Elapsed));
        }
    }
}
