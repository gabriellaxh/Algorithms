using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };

            SelectionSort(array);

            Console.WriteLine(string.Join(" ", array));
        }

        private static void SelectionSort(int[] array)
        {
            int temp, min_key_pos;

            for (int i = 0; i < array.Length - 1; i++)
            {
                min_key_pos = i;

                //find the position of the smallest element in the row
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min_key_pos])
                        min_key_pos = j;
                }

                //swaps the position of the smallest element with the one of the greater element
                temp = array[min_key_pos];
                array[min_key_pos] = array[i];
                array[i] = temp;
            }
        }
    }
}
