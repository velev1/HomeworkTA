namespace Exceptions_homework
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Utils
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            List<T> result = new List<T>();

            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("The array cannot be null or empty.");
            }

            if (startIndex < 0 || startIndex > arr.Length)
            {
                throw new IndexOutOfRangeException("The start index is outside the array.");
            }

            if (startIndex + count > arr.Length)
            {
                throw new ArgumentException("The count is too big for that lenght of the array.");
            }

            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (str == null || str == string.Empty)
            {
                throw new ArgumentException("The string cannot be null or empty");
            }

            StringBuilder result = new StringBuilder();

            if (count > str.Length)
            {
                // two options here the first is to throw exception if the count is greater than the 
                // string lenght
                // throw new ArgumentException("The count must be less or equal to the string length");

                // and the second is if count is greater than the string length return the entire string 
                result.Append(str);
                return result.ToString();
            }

            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static void CheckPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0 || number < 1)
                {
                    throw new ArgumentException(string.Format("The number {0} is not prime!", number));
                }
            }
        }
    }
}
