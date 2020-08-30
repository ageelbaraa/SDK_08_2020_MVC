using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpCodes
{
    class GArray<T>
    {
        static int initSize = 2;
        private T[] array;
        public int Size { get; set; }
        public GArray():this(initSize)
        {}

        public GArray(int capacity)
        {
            if (capacity > 0)
                array = new T[capacity];
            else
                array = new T[initSize];
        }
        public void Add(T t)
        {
            if (IsFull())
                Expand();
            array[Size++] = t;
        }

        private void Expand()
        {
            T[] temp = new T[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = temp[i];
            }
            array = temp;
        }
        public bool Add(int index, T t)
        {
            if (index < 0 || index > Size)
                return false;

            if (IsFull())
            {
                Expand(index, t);
                return true;
            }

            int j = Size;
            while (j > index)
            {
                array[j] = array[j - 1];
                j--;
            }
            array[index] = t;
            Size++;
            return true;
        }

        private void Expand(int index, T t)
        {
            T[] temp = new T[array.Length * 2];  // array.Length << 1
            for (int i = 0; i < array.Length; i++)
            {
                if (i < index)
                    temp[i] = array[i];
                else if (i == index)
                    temp[i] = t;
                else
                    temp[i] = array[i - 1];
            }
            Size++;
            array = temp;
        }

        private bool IsFull()
        { return array.Length == Size; }

        public override string ToString()
        {
            if (Size == 0)
                return "{}";

            if (Size == 1)
                return "{" + array[0] + "}";

            StringBuilder builder = new StringBuilder("{");
            for (int i = 0; i < Size; i++)
                builder.Append(array[i]).Append(i == Size - 1 ? "}" : ", ");
            return builder.ToString();
        }


        public T Remove(int index)
        {
            // TODO: Remove the element at the specified index, and return it or return null otherwise
            if (index < 0 || index > Size - 1)
                return default(T);
            //throw new ArgumentOutOfRangeException("Index out of range:" + index);

            T temp = array[index];
            for (int i = index + 1; i < Size; i++)
            {
                array[i - 1] = array[i];
            }
            Size--;
            return temp;
        }

        public bool Remove(T element)
        {
            // TODO: Remove  the first occurence of the element with specified value,
            //and return true if it was removed or return false otherwise.
            int index = Find(element);
            if (index < 0) return false;

            return Remove(index) != null;
        }

        public int RemoveAll(T element)
        {
            // TODO: Remove All  occurences of the element with specified value, 
            //and return the number of removed elements, or 0 if no element was removed.
            int counter = 0;
            while (Remove(element))
                counter++;
            return counter;
        }
        public T RemoveFirst()
        {
            // TODO: Remove the first element, 
            // and return it, or null if empty array.
            return Remove(0);
        }
        public T RemoveLast()
        {
            // TODO: Remove the last element, 
            //and return it, or null if empty array.
            return Remove(Size - 1);
        }
        public int Find(T element)
        {
            // TODO: Find the first occurence of the element, 
            // and return it's index, or -1 if not exist.
            for (int i = 0; i < Size; i++)
            {
                if (array[i].Equals(element))
                    return i;
            }
            return -1;

        }
        public int[] FindAll(T element)
        {
            // TODO: Find the index of All occurence of the element, 
            // and return array of the index, or null if not exist.
            int counter = 0;
            for (int i = 0; i < Size; i++)
            {
                if (array[i].Equals(element))
                    counter++;
            }
            if (counter == 0)
                return null;

            int[] indexs = new int[counter];
            for (int i = 0, j = 0; i < counter; i++)
            {
                if (array[i].Equals(element))
                    indexs[j++] = i;
            }

            return indexs;
        }

        public int[] FindAll1(T element)
        {
            // TODO: Find the index of All occurence of the element, 
            // and return array of the index, or null if not exist.

            StringBuilder builder = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < Size; i++)
            {
                if (array[i].Equals(element))
                {
                    counter++;
                    builder.Append(i).Append(",");
                }

            }
            if (counter == 0)
                return null;

            int[] indexs = new int[counter];
            builder.Remove(builder.Length - 1, 1);
            String[] split = builder.ToString().Split(',');
            for (int i = 0; i < indexs.Length; i++)
            {
                indexs[i] = int.Parse(split[i]);
            }

            return indexs;
        }

        public bool Contains(T element)
        {
            // TODO: check if the array contains the specified element.
            // return true if exist or false otherwise.
            return Find(element) != -1;
        }

        public void Repeat(T element, int count)
        {
            // TODO: add the element repeatidly  n number of times at the end .
            // Example : {1,2,3,4,5}    after Repeat(10,3) it will be {1,2,3,4,5,10,10,10}
            Repeat(element, Size, count);
        }
        public void Repeat(T element, int offset, int count)
        {
            // TODO: add the element repeatidly  n number of times  strating from index offset.
            // Example : {1,2,3,4,5}    after Repeat(10,2,3) it will be {1,2,10,10,10,3,4,5}

            if (offset < 0 || offset > Size)
                throw new ArgumentOutOfRangeException("Offset out of range:" + offset);

            if (count < 0)
                throw new ArgumentOutOfRangeException("Negative count value:" + count);

            for (int i = 0; i < count; i++)
                Add(offset, element);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            GArray<string> arr = new GArray<string>();
            Console.WriteLine(arr);
            arr.Add("1");
            Console.WriteLine(arr);
            arr.Add("2");
            arr.Add("3");
            arr.Add("4");
            arr.Add("5");
            arr.Add("6");
            Console.WriteLine(arr);
            arr.Add(1, "8");
            Console.WriteLine(arr);
            Console.ReadKey();
        }
    }
}
