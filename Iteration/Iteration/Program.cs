using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Iterative Password Check Program
             * 
            */

            // Variables 
            string userInput;
            int count = 0;

            // Program
            do
            {
                count++;

                Console.Write("Entre Password: ");
                userInput = Console.ReadLine();

                if(PasswordCheck(userInput) == false)
                {
                    Console.WriteLine("Incorrect.");
                }

            } while (PasswordCheck(userInput) == false && count < 3);

            // Final Check
            if (PasswordCheck(userInput))
            {
                Console.WriteLine("Password Accepted.");

            }
            else
            {
                Console.WriteLine("Access Denied.");
            }

            AnyKey();
        
        }

        static void AnyKey()
        {
            Console.WriteLine("Press Any Key to continue...");
            Console.ReadKey();
        }

        static bool PasswordCheck(string userInput)
        {
            bool correct = false;
            const string password = "sp3lling";

            if (password == userInput)
            {
                correct = true;
            }

            return correct;
        }
    }
}
