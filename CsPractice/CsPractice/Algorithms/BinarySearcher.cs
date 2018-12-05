using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice.Algorithms
{
    public class BinarySearcher
    {
        private int[] array;

        public BinarySearcher(int[] arrayToSearch)
        {
            array = arrayToSearch;
        }

        public bool BinarySearch(int dataToFind)
        {
            return BinarySearchHelper(dataToFind, array.Length / 2, 0, array.Length - 1);
        }

        private bool BinarySearchHelper(int dataToFind, int searchIndex, int leftIndex, int rightIndex)
        {
            if (dataToFind == array[searchIndex])
            {
                return true;
            }
            else if (dataToFind < array[searchIndex])
            {
                if (leftIndex == searchIndex)
                {
                    return false;
                }
                return BinarySearchHelper(dataToFind, (searchIndex - leftIndex) / 2, leftIndex, searchIndex - 1);
            }
            else
            {
                if (rightIndex == searchIndex)
                {
                    return false;
                }
                return BinarySearchHelper(dataToFind, searchIndex + ((rightIndex - searchIndex) / 2) + ((rightIndex - searchIndex) % 2), searchIndex + 1, rightIndex);
            }
        }
    }
}
