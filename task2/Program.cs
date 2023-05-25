using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        const int MAX_WIDTH_DOT = 10;
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] words = Split(str, ' ');

            

            Dictionary<string, int> countWord = new Dictionary<string, int>();
            int lengthMaxWord = 0;

            foreach (string word in words)
            {
                if (!countWord.ContainsKey(word))
                    countWord.Add(word, 0);

                if (lengthMaxWord <= word.Length)
                    lengthMaxWord = word.Length;

                countWord[word]++;
            }

            countWord.OrderBy(x => x.Value);


            foreach (string word in countWord.Keys)
            {
                float freq = (float)countWord[word] / countWord[countWord.Keys.Last()] * MAX_WIDTH_DOT;
                int countDots = (int)Math.Round(freq, 0, MidpointRounding.AwayFromZero);
                string dots = GetSymSeparator(countDots, '.');

                string underscopes = GetSymSeparator(lengthMaxWord - word.Length, '_');

                Console.WriteLine($"{underscopes}{word} {dots}");
            }

           
        }

        static string[] Split(string str, char sep)
        {
            List<string> strings = new List<string>();


            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != sep)
                {
                    sb.Append(str[i].ToString());
                }

                if (str[i] == sep || i == str.Length - 1)
                {
                    strings.Add(sb.ToString());
                    sb.Clear();
                }

            }

            return strings.ToArray();
        }

        static string GetSymSeparator(int count, char sym)
        {
            StringBuilder dots = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                dots.Append(sym);
            }

            return dots.ToString();
        }
    }
}
