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

            int valueOfTheDistant;

            while (gap > 0)
            {
                for (int i = 0; i + gap < array.Length; i++)
                {
                    int indexOfTheDistant = i + gap;
                    valueOfTheDistant = array[j];
                    
                    while (indexOfTheDistant - gap >= 0 && valueOfTheDistant < array[indexOfTheDistant - gap])
                    {
                        array[indexOfTheDistant] = array[indexOfTheDistant - gap];
                        indexOfTheDistant -= gap;
                    }

                    array[indexOfTheDistant] = valueOfTheDistant;
                }

                gap /= 2;
            }
        }
    }
}
