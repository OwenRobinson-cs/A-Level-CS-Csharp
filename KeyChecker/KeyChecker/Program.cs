using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Key Checker Program
             * 18/09/2020
             */

            // Variables 
            //string a = "ABCD";
            //char b = a[0];
            //int c = (int)b;
            string userInput;
            char character;
            int asciiConversion;

            // Get user input
            Console.Write("Enter Character:");
            userInput = Console.ReadLine();

            while (char.TryParse(userInput, out character) == false) 
            {
                Console.Write("Value entered not a character, try again: ");
                userInput = Console.ReadLine();
            }

            // convert to ascii value 

            asciiConversion = (int)character;

            // Check Value

            if (asciiConversion < 33 || asciiConversion == 127)
            {
                Console.WriteLine("Computer Function.");
            }
            else if (asciiConversion < 48 || (asciiConversion < 65 && asciiConversion > 57) || (asciiConversion > 90 && asciiConversion < 97) || asciiConversion > 122)
            {
                Console.WriteLine("Character.");
            }
            else if (asciiConversion < 58)
            {
                Console.WriteLine("Digit.");
            }
            else if (asciiConversion < 91)
            {
                Console.WriteLine("Uppercase");
            }
            else if (asciiConversion < 122) 
            {
                Console.WriteLine("Lowercase");
            }

            AnyKey();
        }

        static void AnyKey()
        {
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadKey();
        }

    }
}
