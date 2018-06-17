using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 5, 7, 754, 23, 52, 9, 2, 1 };

            Console.WriteLine(LinearSearch(array,-1));
        }

        public static bool LinearSearch(int[] array, int item)
        {
            int n = array.Length;

            for (int i = 0; i < n; i++)
            {
                if (array[i] == item)
                    return true;               
            }

            return false;
        }
    }
}
