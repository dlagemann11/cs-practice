using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice.Problems
{
    public class ThreeStacksFromArray<T>
    {
        private T[] array;
        private int[] counts;

        public ThreeStacksFromArray()
        {
            array = new T[3];
            counts = new int[3];
        }

        public void PushFirst(T data)
        {
            Push(0, data);
        }

        public void PushSecond(T data)
        {
            Push(1, data);
        }

        public void PushThird(T data)
        {
            Push(2, data);
        }

        public T PopFirst()
        {
            return Pop(0);
        }

        public T PopSecond()
        {
            return Pop(1);
        }

        public T PopThird()
        {
            return Pop(2);
        }

        private void Push(int stack, T data)
        {
            int index = GetHeadIndex(stack);
            if (index >= array.Length)
            {
                IncreaseSize();
            }
            array[index] = data;
            counts[stack]++;
        }

        private T Pop(int stack)
        {
            int index = GetHeadIndex(stack) - 3;
            counts[stack]--;
            return array[index];
        }

        private int GetHeadIndex(int stack)
        {
            return stack + 3 * counts[stack];
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
