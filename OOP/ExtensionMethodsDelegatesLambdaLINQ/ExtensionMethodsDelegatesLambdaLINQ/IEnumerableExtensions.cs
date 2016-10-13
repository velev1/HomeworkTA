
namespace ExtensionMethodsDelegatesLambdaLINQ
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
            where T : IComparable, IFormattable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection must not be empty");
            }
            dynamic result = 0;

            foreach (var item in collection)
            {
                result += item;
            }
            return result;
        }

        public static T Product<T>(this IEnumerable<T> collection)
            where T : IComparable, IFormattable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection must not be empty");
            }

            dynamic result = 1;

            foreach (var item in collection)
            {
                result *= item;
            }

            return result;
        }

        public static T Min<T>(this IEnumerable<T> collection)
           where T : IComparable, IFormattable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection must not be empty");
            }

            return collection.Min(x => x);
        }

        public static T Max<T>(this IEnumerable<T> collection)
          where T : IComparable, IFormattable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection must not be empty");
            }

            return collection.Max(x => x);
        }

        public static double Average<T>(this IEnumerable<T> collection)
          where T : IComparable, IFormattable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection must not be empty");
            }

            return (0.0 + (dynamic)collection.Sum()) / collection.Count();
        }

        public static int Count<T>(this IEnumerable<T> collection)
        {
            int count = 0;

            foreach (var item in collection)
            {
                count++;
            }
            return count;
        }
    }
}
