using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassFail
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables 
            const int MinScore = 20;
            int accScore;
            string userInput;
            bool pass;

            // Get user input
            Console.Write("Enter Score: ");
            userInput = Console.ReadLine();

            while (int.TryParse(userInput, out accScore) == false)
            {
                Console.Write("Error: Provided value outside range limits, try again: ");
                userInput = Console.ReadLine();
            }

            // Check score

            if (accScore >= MinScore)
            {
                pass = true;
            }
            else
            {
                pass = false;
            }

            // Output 

            if (pass)
            {
                Console.WriteLine("Pass.");
            }
            else
            {
                Console.WriteLine("Fail.");
            }

            Console.ReadKey();
        }
    }
}
