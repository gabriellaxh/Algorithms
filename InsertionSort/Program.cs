using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 36, 7, 10, 3, 2, 94, 88, 13, 53, 4, 1 };

            InsertionSort(arr);

            Console.WriteLine(string.Join(' ', arr));
        }

        private static void InsertionSort(int[] array)
        {
            int current, j;

            for (int i = 1; i < array.Length; i++)
            {
                //current - the second one of the two adjacent elements
                current = array[i];
                //j - the first one of the two adjacent elements
                j = i - 1;

                
                while (j >= 0 && current < array[j])
                {
                    //while the second one is smaller than the first one swap their positions
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = current;
            }
        }
    }
}
