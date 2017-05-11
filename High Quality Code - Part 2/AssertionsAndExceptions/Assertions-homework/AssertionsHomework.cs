namespace Assertions_homework
{
    using System;

    public class AssertionsHomework
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));

            // If you comment the line with the sorting the assertion apears,
            // because can't perfeorm binary search with not sorted array
            Sort.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            // Test sorting empty array
            // Sort.SelectionSort(new int[0]); 
            Sort.SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(Search.BinarySearch(arr, -1000));
            Console.WriteLine(Search.BinarySearch(arr, 0));
            Console.WriteLine(Search.BinarySearch(arr, 17));
            Console.WriteLine(Search.BinarySearch(arr, 10));
            Console.WriteLine(Search.BinarySearch(arr, 1000));
        }
    }
}
