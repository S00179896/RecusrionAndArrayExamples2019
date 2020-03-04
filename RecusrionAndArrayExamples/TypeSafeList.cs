using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecusrionAndArrayExamples
{
    public class TypeSafeList<T>
    {
        T[] innerArray = new T[0];
        int currentSize = 0;
        int capacity = 0;

        public void Add(T item)
        {
            if (currentSize == capacity)
            {
                capacity = capacity == 0 ? 4 : capacity * 2;  // double capacity 
                T[] copy = new T[capacity];    // create newly sized array
                Array.Copy(innerArray, copy, currentSize);  // copy over the array
                innerArray = copy;    // assign innerArray to the new, larger array
            }
            innerArray[currentSize] = item;
            currentSize++;
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= currentSize)
                    throw new IndexOutOfRangeException();
                return innerArray[index];
            }
            set
            {
                if (index < 0 || index >= currentSize)
                    throw new IndexOutOfRangeException();
                innerArray[index] = value;
            }
        }
        public override string ToString()
        {
            string output = string.Empty;
            for (int i = 0; i < currentSize - 1; i++)
                output += innerArray[i] + ", ";

            return output + innerArray[currentSize - 1];
        }


    }
}
