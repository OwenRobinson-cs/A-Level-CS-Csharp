using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int age;
            const int reqAge = 18;
            string userInput;

            // Get Input
            Console.Write("Enter Age: ");
            userInput = Console.ReadLine();

            while (int.TryParse(userInput, out age) == false)
            {
                Console.Write("Inputted value not a number.");
                userInput = Console.ReadLine();
            }

            // Check Age 

            if (age >= reqAge)
            {
                Console.WriteLine("Okay to serve.");

            }
            else
            {
                Console.WriteLine("Do not serve.");
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
