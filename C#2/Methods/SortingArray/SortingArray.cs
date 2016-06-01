using System;

class SortingArray
{
    static string SelectionSort(string[] array)
    {
        int lastIndex = 0;
        int min = int.MaxValue;
        int minIndex = 0;
        int temp = 0;

        while (lastIndex < array.Length - 1)
        {

            for (int i = lastIndex; i < array.Length; i++)
            {
                if (Convert.ToInt32(array[i]) < min)
                {
                    min = Convert.ToInt32(array[i]);
                    minIndex = i;
                }
            }
            temp = Convert.ToInt32(array[lastIndex]);
            array[lastIndex] = min.ToString();
            array[minIndex] = temp.ToString();
            min = int.MaxValue;
            lastIndex++;
        }
        string sortedArr = string.Join(" ", array);
        return sortedArr;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string result =  SelectionSort(numbers);

        Console.WriteLine(result);
    }
}

