using System;

namespace FuncAndDelegate
{
    public class Program
    {
        delegate string[] ExtractMethod(string title, int limit);
        static string title = "The Scarlet Letter";

        static void Main()
        {
            ExplicitlyDefineADelegate();
            InstantiateAFuncDelegate();

            Console.Read();
        }

        static void ExplicitlyDefineADelegate()
        {
            ExtractMethod extractMethod = ExtractWords;
            WriteItOut(extractMethod);
        }

        static void InstantiateAFuncDelegate()
        {
            Func<string, int, string[]> extractMethod = ExtractWords;
            WriteItOut(extractMethod);
        }

        static string[] ExtractWords(string title, int limit)
        {
            char[] delimiters = new char[] { ' ' };
            if (limit > 0)
                return title.Split(delimiters, limit);
            else
                return title.Split(delimiters);
        }

        static void WriteItOut(ExtractMethod extractMethod)
        {
            foreach (string word in extractMethod(title, 5))
            {
                Console.WriteLine(word);
            }
        }

        static void WriteItOut(Func<string, int, string[]> extractMethod)
        {
            foreach (string word in extractMethod(title, 5))
            {
                Console.WriteLine(word);
            }
        }
    }
}
