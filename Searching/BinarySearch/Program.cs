using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 5, 7, 9, 23, 52, 69, 72, 91 };

            Console.WriteLine(BinarySearch(array,0,array.Length-1, 69));
        }

        public static bool BinarySearch(int[] array, int start, int end, int item)
        {
            if (start < end)
            {
                int middle = (start + end) / 2;

                if (array[middle] == item)
                    return true;

                else if (array[middle] > item)
                    return BinarySearch(array, start, middle - 1, item);

                else
                    return BinarySearch(array, middle + 1, end, item);
            }
            return false;
        }
    }
}
