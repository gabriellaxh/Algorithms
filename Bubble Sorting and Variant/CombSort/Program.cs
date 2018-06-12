using System;

namespace CombSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[14] { 0, 46, 20, 2, -25, 0, 4, -78, 8, 60, 7, 70, 98, 30 };

            CombSort(array);

            Console.WriteLine(string.Join(" ", array));
        }

        private static void CombSort(int[] array)
        {
            int gap = array.Length;

            while (gap > 1)
            {
                gap = (int)(gap / 1.3);

                int i = 0;

                while (i + gap < array.Length)
                {
                    if (array[i] > array[i + gap])
                    {
                        int temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;
                    }

                    i++;
                }
            }
        }
    }
}
