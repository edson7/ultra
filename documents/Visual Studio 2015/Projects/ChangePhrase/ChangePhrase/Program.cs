using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangePhrase
{
    class Program
    {
        static void Main(string[] args)
        {

            string phrase = "La vie est Belle";

            string result = ProcessPhrase(phrase);

            ShowConsole(result);

            Console.ReadKey();

        }

        public static string ProcessPhrase(string phrase)
        {
            StringBuilder sb = new StringBuilder();

            string[] result = phrase.Split(' ');

            for (int i = result.Length - 1; i >= 0; i--)
            {
                sb.Append(result[i] + " ");
            }
            string phraseTraiter = sb.ToString();
            return phraseTraiter;
        }

        public static void ShowConsole(string phraseTraiter)
        {
            Console.Write(phraseTraiter);
        }
    }
}
