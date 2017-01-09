namespace Longest_String
{
    using System;
    using System.Linq;

    public class FindLongestString
    {
        static void Main()
        {

            string[] arr = new string[] { "123", "gosho", "rrr", "long string", "very very loooong string", "some string", "bubkn" };


            var theLongestString =
                from str in arr
                orderby str.Length descending
                select str;

            Console.WriteLine(theLongestString.FirstOrDefault());

        }
    }
}
