using System;

namespace IsPalindrom
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var isPolindrom = IsPalindrom(word);
            Console.WriteLine(isPolindrom);
        }

        private static bool IsPalindrom(string word)
        {
            if (word.Length <= 1)
            {
                return true;
            }
            if (word[0] != word[word.Length - 1])
            {
                return false;
            }
            return IsPalindrom(word.Substring(1, word.Length - 2));
        }
    }
}
