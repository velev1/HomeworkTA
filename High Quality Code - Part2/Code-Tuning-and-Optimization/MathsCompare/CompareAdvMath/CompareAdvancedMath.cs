namespace CompareAdvMath
{
    using System;
    using System.Diagnostics;

    public class CompareAdvancedMath
    {
        private const int TIMES_TO_INVOKE = 1000000;

        public static void Main()
        {
            double doubleNumber = 10;
            float floatNumber = 10;
            decimal decimalNumber = 10;

            MisureTimeSqrtDouble(doubleNumber);

            MisureTimeSqrtFloat(floatNumber);

            MisureTimeSqrtDecimal(decimalNumber);

            Console.WriteLine("-------------------------------------------------");

            MisureTimeLogDouble(doubleNumber);

            MisureTimeLogFloat(floatNumber);

            MisureTimeLogDecimal(decimalNumber);

            Console.WriteLine("-------------------------------------------------");

            MisureTimeSinusDouble(doubleNumber);

            MisureTimeSinusFloat(floatNumber);

            MisureTimeSinusDecimal(decimalNumber);
        }

        private static void MisureTimeSinusFloat(float number)
        {
            var sw = Stopwatch.StartNew();

            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                Math.Sin(number);
            }

            sw.Stop();

            Console.WriteLine(string.Format("{0,30} {1}", "Sinus with float time: ", sw.Elapsed));
        }

        private static void MisureTimeSinusDecimal(decimal number)
        {
            var sw = Stopwatch.StartNew();

            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                Math.Sin((double)number);
            }

            sw.Stop();

            Console.WriteLine(string.Format("{0,30} {1}", "Sinus with decimal time: ", sw.Elapsed));
        }

        private static void MisureTimeSinusDouble(double number)
        {
            var sw = Stopwatch.StartNew();

            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                Math.Sin(number);
            }

            sw.Stop();

            Console.WriteLine(string.Format("{0,30} {1}", "Sinus with double time: ", sw.Elapsed));
        }

        private static void MisureTimeLogDecimal(decimal number)
        {
            var sw = Stopwatch.StartNew();

            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                Math.Log((double)number);
            }

            sw.Stop();

            Console.WriteLine(string.Format("{0,30} {1}", "Log with decimal time: ", sw.Elapsed));
        }

        private static void MisureTimeLogFloat(float number)
        {
            var sw = Stopwatch.StartNew();

            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                Math.Log(number);
            }

            sw.Stop();

            Console.WriteLine(string.Format("{0,30} {1}", "Log with float time: ", sw.Elapsed));
        }

        private static void MisureTimeLogDouble(double number)
        {
            var sw = Stopwatch.StartNew();

            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                Math.Log(number);
            }

            sw.Stop();

            Console.WriteLine(string.Format("{0,30} {1}", "Log with double time: ", sw.Elapsed));
        }

        private static void MisureTimeSqrtDecimal(decimal number)
        {
            var sw = Stopwatch.StartNew();

            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                Math.Sqrt((double)number);
            }

            sw.Stop();

            Console.WriteLine(string.Format("{0,30} {1}", "sqrt with decimal time: ", sw.Elapsed));
        }

        private static void MisureTimeSqrtFloat(float number)
        {
            var sw = Stopwatch.StartNew();

            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                Math.Sqrt(number);
            }

            sw.Stop();

            Console.WriteLine(string.Format("{0,30} {1}", "sqrt with float time: ", sw.Elapsed));
        }

        private static void MisureTimeSqrtDouble(double number)
        {
            var sw = Stopwatch.StartNew();

            sw.Start();

            for (int i = 0; i < TIMES_TO_INVOKE; i++)
            {
                Math.Sqrt(number);
            }

            sw.Stop();

            Console.WriteLine(string.Format("{0,30} {1}", "sqrt with double time: ", sw.Elapsed));
        }
    }
}
