using System;

namespace BubbleSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 63, 17, 10, 16, 3, 38 };

            BubbleSort(arr);

            Console.WriteLine(string.Join(' ', arr));
        }

        private static void BubbleSort(int[] array)
        {
            int temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
        }
    }
}
