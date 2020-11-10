using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace QuizProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string name;

            DisplayName();
            name = GetUserName();
            AnyKey();
            PlayQuiz();
            AnyKey();
        }

        static void DisplayName()
        {
            Console.Clear();
            Console.WriteLine("Computer Science Quiz");
            Console.WriteLine("=====================\n");
        }

        static string GetUserName()
        {
            string name = null;
            while (name == null)
            {
                Console.Write("Enter Name: ");
                name = Console.ReadLine();
            }
            return name;
        }

        static void PlayQuiz()
        {
            string[,] questions = {
                {"What is 15.75 in fixed point binary?","11111100" },
                {"What is the smallest number in 8 bit two's complement?","-128" },
                {"What is the biggest number in 4 bit two's complement?","7" },
                {"Where in memory are arrays declared?","The heap" },
                {"Where in memory are variables declared in subroutines?","The stack" },
                {"What is it called when a frame is added to the stack?","pushing" },
                {"what is it called when a frame is removed from the stack?","popping" },
                {"When using parameters in procedures, variables are passed by....","value" },
                {"When using parameters in procedures, objects and arrays are passed by...","reference" },
                {"Which type of subroutine always returns a value?","function" }
            };
            int score;
            bool play = true;
            char playAgain;
            while (play)
            {
                score = 0;
                for (int i = 0; i < (questions.Length / 2); i++)
                {
                    DisplayName();

                    // Ask Question and Update Score
                    if (AskQuestion(questions[i, 0], questions[i, 1]))
                    {

                        Console.WriteLine("Correct.");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect, answer was {0}", questions[i, 1]);
                    }
                    AnyKey();
                }
                DisplayName();
                DisplayScore(score);

                // Play again?

                Console.WriteLine("Would you like to play again? Y/N");            
                while(! char.TryParse(Console.ReadLine().ToLower(), out playAgain) ||playAgain != 'y' && playAgain != 'n')
                {
                    Console.WriteLine("Invalid Input, try again.");
                }

                if (playAgain == 'n')
                {
                    play = false;
                }
            }
        }

        static bool AskQuestion(string question, string answer)
        {
            // La Variable
            string userAnswer;

            // Display Question
            Console.WriteLine(question);
            // Get Answer
            userAnswer = Console.ReadLine();
            while(userAnswer == "")
            {
                Console.WriteLine("Answer cannot be blank");
                userAnswer = Console.ReadLine();
            }
            // CheckAnswer

            return IsCorrectAnswer(userAnswer, answer);
        }

        static bool IsCorrectAnswer(string userAnswer, string answer)
        {
            if (userAnswer.ToLower() == answer.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void DisplayScore(int score)
        {
            Console.WriteLine("Score = {0}", score);
        }

        static void AnyKey()
        {
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadKey();
        }
    }
}
