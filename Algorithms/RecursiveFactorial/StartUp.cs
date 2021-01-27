using System;

namespace RecursiveFactorial
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var result = Factorial(number);
            Console.WriteLine(result);
        }

        private static long Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number should be positive!");
            }
            if (number == 0)
            {
                return 1;
            }

            return number * (Factorial(number - 1));
        }
    }
}
