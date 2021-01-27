using System;

namespace InsertionSort
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var array = new int[] { 50, 3, 15, 6, 0, 11, 13, -1 };
            var sortedArray = InsertionSort(array);
            Print(sortedArray);
        }

        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                Insert(array, i - 1, array[i]);
                //var current = array[i];
                //var j = i - 1;
                //while (j >= 0 && array[j] > current)
                //{
                //    array[j + 1] = array[j];
                //    j--;
                //}
                //array[j + 1] = current;
            }           
            return array;
        }

        public static void Insert(int[] array, int rightIndex, int value)
        {
            for (int i = rightIndex; i >= 0; i--)
            {
                var current = array[i];
                var j = i + 1;
                while (j >= 0 && array[j] < current)
                {
                    array[j] = current;
                    j--;
                }
                if (array[j] > value)
                {
                    array[j] = value;
                }
            }
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
