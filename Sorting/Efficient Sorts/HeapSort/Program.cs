using System;

namespace HeapSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 63, 17, 10, 16, 3, 38 };

            Sort(arr);

            Console.WriteLine(string.Join(' ', arr));
        }

        private static void Sort(int[] array)
        {
            int n = array.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                HeapSort(array, n, i);
            }

            //Sort the built heap
            for (int i = n-1; i >= 0; i--)
            {
                // Move current root to end(the biggest num to the end)
                int temp = array[i];
                array[i] = array[0];
                array[0] = temp;

                HeapSort(array, i, 0);
            }
        }

        private static void HeapSort(int[] array, int n, int i)
        {
            int largest = i;
            int leftChild = 2 * i + 1;
            int rightChild = 2 * i + 2;

            if (leftChild < n && array[leftChild] > array[largest])
                largest = leftChild;

            if (rightChild < n && array[rightChild] > array[largest])
                largest = rightChild;

            if (largest != i)
            {
                int temp = array[i];
                array[i] = array[largest];
                array[largest] = temp;

                // Recursively heapify the affected sub-tree
                HeapSort(array, n, largest);
            }
        }
    }
}
