using System;

namespace CsPractice.Algorithms
{
    public class MergeSorter<T> where T : IComparable
    {
        public void MergeSort(T[] array)
        {
            MergeSortHelper(array);
        }


        private T[] MergeSortHelper(T[] array)
        {
            if (array.Length < 2)
            {
                return array;
            }

            int startOfRightArray = array.Length / 2;
            T[] leftArray = new T[startOfRightArray];
            T[] rightArray = new T[array.Length - startOfRightArray];

            for (int i = 0; i < leftArray.Length; i++)
            {
                leftArray[i] = array[i];
            }
            for (int i = startOfRightArray; i < array.Length; i++)
            {
                rightArray[i - startOfRightArray] = array[i];
            }

            T[] sortedLeftArray = MergeSortHelper(leftArray);
            T[] sortedRightArray = MergeSortHelper(rightArray);

            int leftIndex = 0;
            int rightIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (leftIndex >= sortedLeftArray.Length)
                {
                    array[i] = sortedRightArray[rightIndex];
                    rightIndex++;
                }
                else if (rightIndex >= sortedRightArray.Length)
                {
                    array[i] = sortedLeftArray[leftIndex];
                    leftIndex++;
                }
                else if (sortedLeftArray[leftIndex].CompareTo(sortedRightArray[rightIndex]) <= 0)
                {
                    array[i] = sortedLeftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[i] = sortedRightArray[rightIndex];
                    rightIndex++;
                }
            }

            return array;
        }
    }
}
