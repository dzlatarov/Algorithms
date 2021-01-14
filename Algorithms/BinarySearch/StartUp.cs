using System;

namespace BinarySearch
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var array = new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89 };
            var value = 19;
            var index = BinarySearch(array, value);
            Console.WriteLine(index);
        }

        public static int BinarySearch(int[] array, int value)
        {
            var min = 0;
            var max = array.Length;

            while (min < max)
            {
                var mid = (min + max) / 2;
                if (array[mid] == value)
                {
                    return mid;
                }
                else if (array[mid] < value)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid;
                }
            }
            return -1;
        }
    }
}
