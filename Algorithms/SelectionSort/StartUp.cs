using System;

namespace SelectionSort
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var array = new int[] { 5, 2, 20, 55, 21, -1 };
            var sortedArray = SelectionSort(array);
            PrintArray(sortedArray);
        }

        public static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var minIndex = FindMinimumIndex(array, i);
                Swap(array, i, minIndex);
            }
            return array;
        }

        public static int FindMinimumIndex(int[] array, int startIndex)
        {
            var minIndex = startIndex;
            var minValue = array[startIndex];

            for (int i = minIndex + 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minIndex = i;
                    minValue = array[i];
                }
            }

            return minIndex;
        }


        public static void Swap(int[] array, int firstIndex, int secondIndex)
        {
            var temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }

        public static void PrintArray(int[] array)
        {
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
        }
    }
}
