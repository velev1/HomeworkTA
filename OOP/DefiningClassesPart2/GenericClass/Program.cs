
namespace GenericClass
{
    using System;
    public class Program
    {
        static void Main()
        {
            var list = new GenericList<int>(8);
            list.Add(4);
            list.Add(22);
            list.Add(12);

            list.Insert(1, 2222);
            list.Insert(1, -33);

            Console.WriteLine(list);

            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());

        }
    }
}
