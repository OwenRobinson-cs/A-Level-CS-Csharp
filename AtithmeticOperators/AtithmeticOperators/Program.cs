using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Computer Science 15/09/2020
             * Arithmetic Operators task 2, Circle calculator.
             */

            // Define Variables
            decimal radius;
            decimal area;
            decimal circumference;
            string userInput;

            // Get radius

            title();
            Console.Write("Entre the radius of the circle: ");
            userInput = Console.ReadLine();
            while (decimal.TryParse(userInput, out radius) == false)
            {
                Console.WriteLine("Inputted value contained non-supported characters, re-try.");
                userInput = Console.ReadLine();
                decimal.TryParse(userInput, out radius);
            }

            // Calculate Area (Pi(radius)^2)
            area = (decimal.Parse(Math.PI.ToString()) * (radius * radius));

            // Calculate circumference 2Pi(radius)

            circumference = 2 * (decimal.Parse(Math.PI.ToString()) * radius);

            // Output values 

            Console.WriteLine("The Area of your circle is {0} and the circumference is {1}.", area, circumference);

            AnyKey();
        }

        static void title()
        {
            Console.WriteLine("Circle Calculator");
            Console.WriteLine("*****************");
        }

        static void AnyKey()
        {
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadKey();
        }
    }
}
