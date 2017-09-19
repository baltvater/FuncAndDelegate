using System;

namespace FuncAndDelegate
{
    class Program
    {
        delegate string[] ExtractMethod(string title, int limit);

        static void Main()
        {
            ExtractMethod extractMethod = ExtractWords;
            string title = "The Scarlet Letter";
            foreach (string word in extractMethod(title, 5))
            {
                Console.WriteLine(word);
            }

            Console.Read();
        }

        private static string[] ExtractWords(string title, int limit)
        {
            char[] delimiters = new char[] { ' ' };
            if (limit > 0)
                return title.Split(delimiters, limit);
            else
                return title.Split(delimiters);
        }
    }
}
