using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            int end;
            Console.Write("Enter a word: ");
            word = Console.ReadLine();
            
            end = 1;
            for (int i = word.Length / 2; i >= 0; i--)
            {

                Console.WriteLine(word.Substring(i, end).PadLeft(word.Length - i));
                
                 end+= 2;
            }
            Console.ReadLine();
        }
    }
}
