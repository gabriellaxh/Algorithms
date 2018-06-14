using System;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 6, 5, 3, 0, -20, 1, 8, 7, 2, 4 };

            Sort(arr, 0, arr.Length - 1);

            Console.WriteLine(string.Join(' ', arr));
        }

        private static void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = QuickSort(array, left, right);

                Sort(array, left, pivot - 1);

                Sort(array, pivot + 1, right);
            }
        }

        private static int QuickSort(int[] array, int left, int right)
        {
            int temp;

            int pivot = array[right];

            int idxLastSmallerThanPivotNum = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] <= pivot)
                {
                    idxLastSmallerThanPivotNum++;

                    temp = array[idxLastSmallerThanPivotNum];
                    array[idxLastSmallerThanPivotNum] = array[j];
                    array[j] = temp;
                }
            }

            //moves the pivot on the right place in the list
            temp = array[idxLastSmallerThanPivotNum + 1];
            array[idxLastSmallerThanPivotNum + 1] = array[right];
            array[right] = temp;

            return idxLastSmallerThanPivotNum + 1;
        }
    }
}
