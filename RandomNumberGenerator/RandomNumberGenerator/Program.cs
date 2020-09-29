using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maths Quiz thing
            const int maxScore = 10;
            int num1;
            int num2;
            int userInput;
            int score = 0;
            int questionsAsked = 0;
            bool difficultyHard;
            int minNum = 5;
            int maxNum = 21;
            Random RNG = new Random();

            Console.ForegroundColor = ConsoleColor.Green; 
            difficultyHard = SelectDifficulty();
            if (difficultyHard)
            {
                minNum = -100;
                maxNum = 101;
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            Console.Clear();
            while (score < maxScore)
            {
                num1 = RNG.Next(minNum, maxNum);
                num2 = RNG.Next(minNum, maxNum);
                AskQuestion(num1, num2, score);
                while (int.TryParse(Console.ReadLine(), out userInput) == false)
                {
                    Console.WriteLine("Invalid Value entered, try again.");
                }

                if (num1 + num2 == userInput)
                {
                    score++;
                    Console.WriteLine("Correct.");
                    AnyKey();
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                    AnyKey();
                }
                Console.Clear();
                questionsAsked++;
            }
            Console.WriteLine("Questions Asked: {0}", questionsAsked);
            AnyKey();
            
        }

        static void AskQuestion(int num1, int num2, int score)
        {
            Console.WriteLine("Addition Quiz");
            Console.WriteLine("Correct Answers: {0}", score);
            Console.WriteLine("=============\n \n");
            Console.WriteLine(num1.ToString().PadLeft(12));
            Console.WriteLine("+" + num2.ToString().PadLeft(11));
            Console.WriteLine("=============");
        }

        static void AnyKey()
        {
            Console.WriteLine("Press Any Key to Continue....");
            Console.ReadKey();
        }

        static bool SelectDifficulty()
        {
            bool hard = false;
            string userInput;
            Console.WriteLine("Select Difficulty: Easy or Hard");
            userInput = Console.ReadLine();
            if (userInput.ToUpper() == "HARD")
            {
                hard = true;
            }

            return hard;
        }
    }
}
