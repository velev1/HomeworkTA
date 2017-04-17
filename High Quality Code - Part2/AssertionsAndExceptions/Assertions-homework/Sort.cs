namespace Assertions_homework
{
    using System;
    using System.Diagnostics;

    public class Sort
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(!(arr == null || arr.Length == 0), "The array cannot be null or empty.");

            if (arr.Length != 1)
            {
                for (int index = 0; index < arr.Length - 1; index++)
                {
                    int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                    Swap(ref arr[index], ref arr[minElementIndex]);
                }
            }
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
          where T : IComparable<T>
        {
            Debug.Assert(startIndex >= 0, "The start index is outside the array.");
            Debug.Assert(startIndex <= arr.Length - 1, "The start index is outside the array.");
            Debug.Assert(endIndex >= 0, "The end index is outside the array.");
            Debug.Assert(endIndex <= arr.Length - 1, "The end index is outside the array.");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }
    }
}
