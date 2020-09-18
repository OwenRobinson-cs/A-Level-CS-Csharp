using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int score;
            string userInput;
            char achievedGrade;
            // Grade Boundaries
            const int a = 80;
            const int b = 70;
            const int c = 60;
            const int d = 50;
            const int e = 40;

            // Get user Score

            Console.Write("Enter Score: ");
            userInput = Console.ReadLine();

            while (int.TryParse(userInput, out score) == false)
            {
                Console.Write("Error: Provided value outside range limits, try again: ");
                userInput = Console.ReadLine();
            }

            // Calculate Grade

            if (score >= a)
            {
                achievedGrade = 'A';
            }
            else if (score >= b)
            {
                achievedGrade = 'B';
            }
            else if (score >= c)
            {
                achievedGrade = 'C';
            }
            else if (score >= d)
            {
                achievedGrade = 'D';
            }
            else if (score >= e)
            {
                achievedGrade = 'E';
            }
            else
            {
                achievedGrade = 'U';
            }

            // Output

            Console.WriteLine(achievedGrade);

            Console.ReadKey();
        }
    }
}
