using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string word;

            // get word

            Console.Write("Enter word: ");
            word = Console.ReadLine();

            // Reverse word
            word = ReverseWord(word);
            Console.WriteLine(word);

            // Output number of words
            Console.WriteLine("{0} words.", NumberOfWords(word));
            Console.ReadKey();
        }

        static string ReverseWord(string input)
        {
            string output = "";

            for (int i = input.Length; i > 0; i--)
            {
                output += input[i - 1];
            }

            return output;
        }

        static string NumberOfWords(string input)
        {
            int numberOfWords = 1;

            if (input == null)
            {
                numberOfWords = 0;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == ' ')
                    {
                        numberOfWords++;
                    }
                }
            }

            return numberOfWords.ToString();
        }
    }
}
