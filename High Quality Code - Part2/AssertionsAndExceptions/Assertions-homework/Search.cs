namespace Assertions_homework
{
    using System;
    using System.Diagnostics;

    public class Search
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(!(arr == null || arr.Length == 0), "The array cannot be null or empty.");

            T[] sortedArray = new T[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                sortedArray[i] = arr[i];
            }

            Array.Sort(sortedArray);

            for (int i = 0; i < arr.Length; i++)
            {
                Debug.Assert(sortedArray[i].Equals(arr[i]), "The array is not sorted, cant't perfeorm binary search.");
            }

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(!(arr == null || arr.Length == 0), "The array cannot be null or empty.");
            Debug.Assert(startIndex >= 0, "The start index is outside the array.");
            Debug.Assert(startIndex <= arr.Length - 1, "The start index is outside the array.");
            Debug.Assert(endIndex >= 0, "The end index is outside the array.");
            Debug.Assert(endIndex <= arr.Length - 1, "The end index is outside the array.");
            Debug.Assert(startIndex < endIndex, "The start index is greater than the end index.");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }
    }
}
