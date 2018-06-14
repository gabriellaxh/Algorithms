using System;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 63, 17, 10, 16, 3, 38 };

            Sort(arr, 0, arr.Length - 1);

            Console.WriteLine(string.Join(' ', arr));
        }

        private static void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                //the middle of the array
                int middle = (left + right) / 2;

                //sorts the left subarray
                Sort(array, left, middle);
                //sorts the right subarray
                Sort(array, middle + 1, right);
                //merges the sorted arrays
                MergeSort(array, left, middle, right);
            }
        }

        public static void MergeSort(int[] array, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            //fills the left subarray
            for (int i = 0; i < leftArray.Length; i++)
                leftArray[i] = array[left + i];

            //fills the right subarray
            for (int i = 0; i < rightArray.Length; i++)
                rightArray[i] = array[middle + 1 + i];

            int leftIndex = 0;
            int rightIndex = 0;

            int initialIndex = left;

            //checks which element is smaller and swap their positions if needed
            while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
            {
                if (leftArray[leftIndex] < rightArray[rightIndex])
                {
                    array[initialIndex] = leftArray[leftIndex];
                    leftIndex++;
                }

                else
                {
                    array[initialIndex] = rightArray[rightIndex];
                    rightIndex++;
                }

                initialIndex++;
            }

            //adds what's in the left subarray (if needed)
            while (leftIndex < leftArray.Length)
            {
                array[initialIndex] = leftArray[leftIndex];
                initialIndex++;
                leftIndex++;
            }

            //adds what's in the right subarray (if needed)
            while (rightIndex < rightArray.Length)
            {
                array[initialIndex] = rightArray[rightIndex];
                initialIndex++;
                rightIndex++;
            }

        }
    }
}
