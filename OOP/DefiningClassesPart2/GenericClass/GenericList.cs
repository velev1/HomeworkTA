namespace GenericClass
{
    using System;
    using System.Text;

    public class GenericList<T>
    {
        private T[] collection;
        private const int initialCapacity = 4;

        public GenericList(int capacity = initialCapacity)
        {
            collection = new T[capacity];
            Count = 0;
        }

        public int Count { get; private set; }

        public int Capacity
        {
            get
            {
                return collection.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                return collection[index];
            }
            set
            {
                collection[index] = value;
            }
        }

        public void Add(T value)
        {
            if (Count == collection.Length)
            {
                collection = IncCollectionCapacity();
                collection[Count] = value;
                Count++;
            }
            else
            {
                collection[Count] = value;
                Count++;
            }
        }
        /// <summary>
        /// removing element by index
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            for (int i = index; i < Count; i++)
            {
                if (i < Count - 1)
                {
                    collection[i] = collection[i + 1];
                }
                else
                {
                    collection[i] = default(T);
                }
            }
            Count--;
        }
        /// <summary>
        /// inserting element at given position
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void InsertAt(int index, T value)
        {
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException("The index must be possitive number and must be less or equal to the Count of the collection.");
            }
            if (Count == collection.Length)
            {
                collection = IncCollectionCapacity();
            }
            Count++;
            for (int i = Count - 1; i > index - 1; i--)
            {
                if (i == 0)
                {
                    break;
                }
                collection[i] = collection[i - 1];
            }
            collection[index] = value;

        }
        /// <summary>
        /// Increasing current capacity of the collection by multyply it with 2
        /// </summary>
        private T[] IncCollectionCapacity()
        {
            var incresedCollection = new T[2 * collection.Length];

            for (int i = 0; i < Count; i++)
            {
                incresedCollection[i] = collection[i];
            }
            collection = incresedCollection;
            return collection;
        }
        /// <summary>
        /// Clear the collection and set the capacity to Initial capacity (4)
        /// </summary>
        public void Clear()
        {
            var clearedCol = new T[initialCapacity];
            collection = clearedCol;
            Count = 0;
        }
        /// <summary>
        /// finding index by its value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public int indexOf(T value, int index = 0)
        {
            for (int i = index; i < Count; i++)
            {
                if (collection[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            for (int i = 0; i < Count; i++)
            {
                output.Append(collection[i].ToString());
                if (i < Count - 1)
                {
                    output.Append(", ");
                }
            }
            return output.ToString();
        }
    }
}
