
namespace ExtensionMethodsDelegatesLambdaLINQ
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class Test
    {
        static void Main()
        {
            var sb = new StringBuilder();
            sb.Append("This is Sparta !!!");
            Console.WriteLine(sb.Substring(0, 4).ToString());
            Console.WriteLine(sb.Substring(5, 2).ToString());
            Console.WriteLine(sb.Substring(8).ToString());

            var arr = new int[] { 1, 2, 3, 5, 6 }; 
            Console.WriteLine("Sum = {0}",arr.Sum());
            Console.WriteLine("Product = {0}",arr.Product());
            Console.WriteLine("Min = {0}",arr.Min());
            Console.WriteLine("Max = {0}",arr.Max());
            Console.WriteLine("Average = {0}",arr.Average());
        }
    }
}
