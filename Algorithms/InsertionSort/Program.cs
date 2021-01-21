using System;

namespace InsertionSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var array = new int[] { 8, 2, 4, 1, 3 };
            var sortedArray = Insert(array);
            Print(sortedArray);
        }

        public static int[] Insert(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var current = array[i];
                var j = i - 1;
                while (j >= 0 && array[j] > current)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = current;
            }

            return array;
        }

        public static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
