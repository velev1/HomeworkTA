namespace PrintStatistics
{
    using System;

    public class Statistics
    {
        public void PrintStatistics(double[] numbers)
        {
            this.PrintMaxValue(numbers);

            this.PrintMinValue(numbers);

            this.PrintAvgValue(numbers);
        }

        public void PrintMaxValue(double[] numbers)
        {
            double maxValue = double.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }
            }

            Console.WriteLine("The max value is:{0}", maxValue);
        }

        public void PrintMinValue(double[] numbers)
        {
            double minValue = double.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > minValue)
                {
                    minValue = numbers[i];
                }
            }

            Console.WriteLine("The min value is:{0}", minValue);
        }

        public void PrintAvgValue(double[] numbers)
        {
            double sumOfNumbers = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sumOfNumbers += numbers[i];
            }

            double avg = sumOfNumbers / numbers.Length;

            Console.WriteLine("The avg number is:{0}", avg);
        }
    }
}