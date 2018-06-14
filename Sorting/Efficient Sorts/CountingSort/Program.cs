using System;

namespace CountingSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] arr = {'g', 'e', 'e', 'k', 's', 'f', 'o',
                    'r', 'g', 'e', 'e', 'k', 's'
                    };

            CountingSort(arr);

            Console.WriteLine("Sorted character array is:");
            Console.WriteLine(string.Join(" ",arr));
        }

        private static void CountingSort(char [] array)
        {
            int n = array.Length;

            char[] output = new char[n];

            int[] countArray = new int[256];

            for (int i = 0; i < 256; i++)
            {
                countArray[i] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                countArray[array[i]]++;
            }

            for (int i = 1; i < 256; ++i)
                countArray[i] += countArray[i - 1];

            for (int i = 0; i < n; i++)
            {
                //-1 because we start counting from 0
                output[countArray[array[i]] - 1] = array[i];
                countArray[array[i]]--;
            }

            for (int i = 0; i < n; i++)
            {
                array[i] = output[i];
            }
        }
    }
}
