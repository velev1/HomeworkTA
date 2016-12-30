//Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
//Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
//Implement methods for adding element, 
//accessing element by index, 
//removing element by index, inserting element at given position, 
//clearing the list, finding element by its value and ToString().
//Check all input parameters to avoid accessing elements at invalid positions.


namespace GenericClass
{
    using System;
    public class Start
    {
        static void Main()
        {
            //Empty constructor with the default capacity. If some value is written like parameter in the constructor
            //the capacity will be equal to this parameter.
            GenericList<int> col = new GenericList<int>();
            //add some elements to the collection
            col.Add(2);
            col.Add(77);
            col.Add(33);
            col.Add(7447);
            Console.WriteLine("the elements of the collection: " + col.ToString());
            Console.WriteLine("The capacity = " + col.Capacity);
            Console.WriteLine("The element at index[1] is: " + col[1]);
            //set new value at index [1] 
            col[1] = 666;
            Console.WriteLine("The new value in index [1] is: " + col[1]);

            Console.WriteLine("Count of the collection = " + col.Count);
            //Removing element at index [0]
            col.RemoveAt(0);
            Console.WriteLine();
            Console.WriteLine("Collection after removing: " + col.ToString());
            Console.WriteLine("Count of the collection after removing: " + col.Count);
            //inserting element in the collection
            Console.WriteLine("collection before inserting: " + col.ToString());
            col.InsertAt(2, 9999999);
            Console.WriteLine("collection after inserting: " + col.ToString());

            //Clear and print capacity and Count
            col.Clear();
            Console.WriteLine();
            Console.WriteLine("After the clear -----------------------");
            Console.WriteLine("Capacity = " + col.Capacity);
            Console.WriteLine("Count = " + col.Count);
            Console.WriteLine("Collection: " + col.ToString());

            //finding index by its value if exist. If do not exist return -1
            col.Add(2);
            col.Add(3);

            int value = 3;
            int index = col.indexOf(value);
            if (index > 0)
            {
                Console.WriteLine("The element with value: {0} is on index: {1}", value, index);
            }
            else
            {
                Console.WriteLine("The element with value: {0} is not found.",value);
            }
            Console.WriteLine(col.ToString());
        }
    }
}
