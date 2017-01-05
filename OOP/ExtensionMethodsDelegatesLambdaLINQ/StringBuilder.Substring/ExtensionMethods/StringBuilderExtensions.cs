namespace StringBuilder.Substring.ExtensionMethods
{
    using System;
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder SubString(this StringBuilder sb, int startIndex, int lenght)
        {
            string str = sb.ToString();
            sb.Clear();
            try
            {
                sb.Append(str.Substring(startIndex, lenght));
            }
            catch (IndexOutOfRangeException)
            {
                throw;
            }
            return sb;
        }

        public static StringBuilder SubString(this StringBuilder sb, int startIndex)
        {
            string str = sb.ToString();
            sb.Clear();
            sb.Append(str.Substring(startIndex));
            return sb;
        }
    }
}
