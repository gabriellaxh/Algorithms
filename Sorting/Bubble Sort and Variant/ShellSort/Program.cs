using System;

namespace ShellSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[12] { 5, 46, 20, 2, 0, -5, 8, 60, 7, 70, 98, 30 };

            ShellSort(array);

            Console.WriteLine(string.Join(" ",array));
        }

        private static void ShellSort(int[] array)
        {
            int gap = array.Length / 2;

            int temp;

            while (gap > 0)
            {
                for (int i = 0; i + gap < array.Length; i++)
                {
                    int j = i + gap;
                    temp = array[j];
                    
                    while (j - gap >= 0 && temp < array[j - gap])
                    {
                        array[j] = array[j - gap];
                        j -= gap;
                    }

                    array[j] = temp;
                }

                gap /= 2;
            }
        }
    }
}
