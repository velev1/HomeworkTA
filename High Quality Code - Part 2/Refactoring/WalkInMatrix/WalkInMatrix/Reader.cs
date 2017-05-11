namespace WalkInMatrix
{
    using System;

    using Contracts;

    public class Reader : IReader
    {
        public string Read()
        {
            char value = (char)Console.Read();

            return value.ToString();
        }

        public string ReadLine()
        {
            string value = Console.ReadLine();

            return value;
        }
    }
}
