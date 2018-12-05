using System;

namespace CsPractice.DataStructures
{
    public class ArrayList<T>
    {
        private T[] array;
        public int Count { get; private set; }

        public T this[int i]
        {
            get => array[i];
            set
            {
                if (i < Count)
                {
                    array[i] = value;
                }
                else if (i == Count)
                {
                    if (Count >= array.Length)
                    {
                        IncreaseSize();
                    }

                    array[i] = value;
                    Count++;                                     
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public ArrayList() : this(1) {}

        public ArrayList(int size)
        {
            array = new T[size];
            Count = 0;
        }

        public void Append(T item)
        {
            this[Count] = item;
        }

        private void IncreaseSize()
        {
            T[] newArray = new T[array.Length * 2];
            
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
    }
}
