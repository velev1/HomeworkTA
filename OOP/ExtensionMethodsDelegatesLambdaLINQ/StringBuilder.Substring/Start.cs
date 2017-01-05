namespace StringBuilder.Substring
{
    using System;
    using System.Text;
    using ExtensionMethods;

    public class Start
    {
        static void Main()
        {
            StringBuilder str = new StringBuilder();

            str.Append("this is a string");
            Console.WriteLine("Initial stringBuilder.");
            Console.WriteLine(str);

            Console.WriteLine();
            Console.WriteLine("Substring of the strBuilder using the first overload int startIndex");
            str.SubString(4);
            Console.WriteLine(str);

            Console.WriteLine();
            Console.WriteLine("Substring of te strBuilder using the second overload int startIndex, int lenght");
            str.SubString(4, 7);
            Console.WriteLine(str);

            Console.WriteLine("===========================================================================");


            int[] arr = { 1, 12, 33, -4, 5 };

            var sum = arr.Sum();
            Console.WriteLine("The sum of the elements in the array is: {0}\n",sum);

            var max = arr.Max();
            Console.WriteLine("The Max is: {0}\n",max);

            var min = arr.Min();
            Console.WriteLine("The Min is: {0}\n",min);

            var product = arr.Product();
            Console.WriteLine("The product is: {0}\n",product);

            var average = arr.Average();
            Console.WriteLine("The avarage is: {0}\n",average);
        }
    }
}
