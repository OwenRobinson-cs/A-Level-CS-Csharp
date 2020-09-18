using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            const string Password = "P4ssw0rd";
            string userInput;

            // Get input

            Console.Write("Entre password: ");
            userInput = Console.ReadLine();

            // Check Password

            if (userInput == Password)
            {
                Console.WriteLine("Password Accepted");

            }
            else { Console.WriteLine("Password not accepted"); }

            AnyKey();
        }

        static void AnyKey()
        {
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadKey();
        }

    }
}
