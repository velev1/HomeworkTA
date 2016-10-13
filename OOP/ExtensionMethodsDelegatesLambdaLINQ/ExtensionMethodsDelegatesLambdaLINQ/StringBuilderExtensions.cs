
namespace ExtensionMethodsDelegatesLambdaLINQ
{
    using System;
    using System.Text;

    public static class StringBuilderExtensions
    {
        //returns substring with specified start index and lenght
        public static StringBuilder Substring(this StringBuilder sb, int startIndex, int length)
        {
            string str = sb.ToString();
            var result = new StringBuilder();
            if (length > str.Length - startIndex || startIndex > str.Length - 1 || startIndex < 0)
            {
                throw new IndexOutOfRangeException("startIndex and length must refer to a location within the string.");
            }
            if (length <= 0)
            {
                throw new ArgumentException("The lenght of the substring must be greater than zero");
            }
            for (int i = startIndex; i < str.Length; i++)
            {
                result.Append(str[i]);
                length--;
                if (length == 0)
                {
                    break;
                }
            }
            return result;
        }
        //returns substring from start index to the end of the string
        public static StringBuilder Substring(this StringBuilder sb, int startIndex)
        {
            string str = sb.ToString();
            var result = new StringBuilder();
            if (startIndex > str.Length - 1 || startIndex < 0)
            {
                throw new IndexOutOfRangeException("startIndex must refer to a location within the string.");
            }
            for (int i = startIndex; i < str.Length; i++)
            {
                result.Append(str[i]);
            }
            return result;
        }

    }
}
