using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* BMI CALCULATOR 
             * 18/09/2020
             * BMI = Mass (kg) / height^2 (m^2)
             */

            // Variables 
            decimal weight;
            decimal height;
            string userInput;
            decimal bmi;

            // Get weight & height

            Console.Write("Please Enter your weight in KG: ");
            userInput = Console.ReadLine();

            while (decimal.TryParse(userInput, out weight) == false)
            {
                Console.Write("Value entered not a number, try again: ");
                userInput = Console.ReadLine();
            }

            Console.WriteLine("Please Enter your height in Metres");
            userInput = Console.ReadLine();

            while (decimal.TryParse(userInput, out height) == false)
            {
                Console.Write("Value entered not a number, try again: ");
                userInput = Console.ReadLine();
            }

            // Calculate BMI

            height = height * height;

            bmi = weight / height;

            // Output

            Console.WriteLine("Your calculated BMI is: {0}", bmi);

            Console.ReadKey();
        }
    }
}
