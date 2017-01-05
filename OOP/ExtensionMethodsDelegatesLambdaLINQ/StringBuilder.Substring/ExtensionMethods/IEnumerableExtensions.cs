namespace StringBuilder.Substring.ExtensionMethods
{
    using System;
    using System.Collections.Generic;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            dynamic sum = 0;
            foreach (var item in collection)
            {
                sum += item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
            where T : IComparable, IFormattable, IConvertible
        {
            dynamic prod = 1;

            foreach (var item in collection)
            {
                prod *= item;
            }
            return prod;
        }

        public static T Max<T>(this IEnumerable<T> collection)
            where T : IComparable, IFormattable, IConvertible
        {
            dynamic max = null;
            dynamic temp = 0;
            foreach (var item in collection)
            {
                temp = item;
                if (temp > max || max == null)
                {
                    max = temp;
                }
            }
            return max;
        }

        public static T Min<T>(this IEnumerable<T> collection)
            where T : IComparable, IFormattable, IConvertible
        {
            dynamic min = null;
            dynamic temp = 0;

            foreach (var item in collection)
            {
                temp = item;
                if (temp < min || min == null)
                {
                    min = temp;
                }
            }
            return min;
        }

        public static T Average<T>(this IEnumerable<T> collection)
            where T : IComparable, IFormattable, IConvertible
        {
            dynamic avg = 0;
            dynamic sum = 0;
            int counter = 0;
            foreach (var item in collection)
            {
                sum += item;
                counter++;
            }
            avg = sum / counter;
            return avg;
        }
    }
}
