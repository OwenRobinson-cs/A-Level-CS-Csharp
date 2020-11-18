using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hangman
{
    class Program
    {
  //Global Definitions
        static string[] Phrases = new String[100];
        static char[] Answer;
        static char[] Dashes;

        static char Guess;
        static int Count;
        static int NumberOfPhrases;
        static int RN;
        static bool Found;

        static string YesNo;
        static int NumberWrong;

        static string Temporary;
        static int i;

        //Main subroutine
        static void Main(string[] args)
        {
            //Set YesNo to Y to say that they want to play hangman
            YesNo = "Y";

            //Get all the available words or phrase out of a file.
            GetPhrasesFromFile();

            do
            {
                //Pick a phrase to guess.
                SetupPhrase();

                // Set the number of wrong guesses to zero 
                NumberWrong = 0;

                //Play the game
                do
                {
                    /** Start playing the game by displaying the current status
                    * and asking for a guess.
                    */
                    DisplayHangman();
                    DisplayCurrentProgress();
                    EnterGuess();

                    //Check if the letter guessed is in the answer
                    //Swap the - to the letter is it is
                    SwapInDashes();

                    //if the letter wasn't found then add one onto the number wrong.
                    if (Found == false) { NumberWrong = NumberWrong + 1; }

                } while (!Answer.SequenceEqual(Dashes) && NumberWrong < 12);

                //Display their over all results
                DisplayHangman();
                DisplayCurrentProgress();
                DisplayResult();

                //Ask if they want another go
                Console.WriteLine("Do you want another go?");
                YesNo = Console.ReadLine().ToUpper();
            } while (YesNo != "N");
        }

        //Gets the phrases from the Phrase.dat file.
        public static void GetPhrasesFromFile()
        {
            StreamReader CurrentFile = new StreamReader("phrases.dat");
            Count = 0;
            while (CurrentFile.Peek() != -1)
            {
                Phrases[Count] = CurrentFile.ReadLine();
                Count++;
            }

            NumberOfPhrases = Count;
            CurrentFile.Close();
        }

        //Pick one of the available phrases at random
        public static void SelectPhraseNumber(ref int RN)
        {
            Random RandomNumberGenerator = new Random();
            RN = RandomNumberGenerator.Next(NumberOfPhrases - 1);
        }

        /**
        * Select one of the available phrase and copy it into
        * the Answer and the Dashes arrays.
        * Answer will also keep track of the correct answer while
        * Dashes will store the "---/---" and the letters correctly guessed.
        * */
        public static void SetupPhrase()
        {
            RN = 0;
            SelectPhraseNumber(ref RN);
            Answer = Phrases[RN].ToCharArray();
            Dashes = Phrases[RN].ToCharArray();

            SetupAnswer();
            SetupDashes();
        }



        /** 
        * Swap all the spaces in the Answer for a / so that when
        * it is checked against the dashes it will match.
        */
        public static void SetupAnswer()
        {
            for (i = 0; i < Answer.Length; i++)
                if (Answer[i] == ' ')
                    Answer[i] = '/';
        }

        //Swap the letters in dashes to '-' and the spaces to '/'
        public static void SetupDashes()
        {
            for (i = 0; i < Dashes.Length; i++)
            {
                if (Dashes[i] == ' ')
                    Dashes[i] = '/';
                else
                    Dashes[i] = '-';
            }
        }

        //Display the current state of the game on screen
        public static void DisplayCurrentProgress()
        {
            Console.WriteLine();
            Console.Write("Phrase To Guess: ");
            Console.WriteLine(Dashes);
            Console.WriteLine();
            Console.WriteLine("Number of wrong guesses: " + NumberWrong);
            Console.WriteLine();
        }

        /**
        * Lets the user guess a letter and converts it to uppercase
        * Also makes sure exactly one letter is entered
        */
        public static void EnterGuess()
        {
            Temporary = "";
            do
            {
                Console.Write("Enter a guess: ");
                Temporary = Console.ReadLine().ToUpper();
                if (Temporary.Length != 1)
                    Console.WriteLine("You must only enter 1 character");
            } while (Temporary.Length != 1);
            Guess = char.Parse(Temporary);
        }



        //Check if the Guess entered is in the answer and swap in the dashes.
        public static void SwapInDashes()
        {
            Found = false;
            for (i = 0; i < Answer.Length; i++)
            {
                if (Answer[i] == Guess)
                {
                    Dashes[i] = Guess;
                    Found = true;
                }
            }
        }

        //Display if they got the answer right or wrong
        public static void DisplayResult()
        {
            if (Answer.SequenceEqual(Dashes))
                Console.WriteLine("Well done!  You got it right");
            else
            {
                Console.Write("Bad Luck!!!  The answer was:");
                Console.WriteLine(Answer);
            }
            Console.WriteLine();
        }
        //Display a picture of the hangman for the number of wrong guesses
        public static void DisplayHangman()
        {
            Console.Clear();
            Console.WriteLine();
            if (NumberWrong >= 3) Console.WriteLine("     ---------"); else Console.WriteLine();
            if (NumberWrong >= 2) Console.Write("     |");
            if (NumberWrong >= 4) Console.Write("  |");
            Console.WriteLine();
            if (NumberWrong >= 2) Console.Write("     |");
            if (NumberWrong == 5) Console.Write("  0");
            else if (NumberWrong == 6) Console.Write("       \\0");
            else if (NumberWrong >= 7) Console.Write("       \\0/");
            Console.WriteLine();
            if (NumberWrong >= 2) Console.Write("     |");
            if (NumberWrong > 7) Console.Write("  |");
            Console.WriteLine();
            if (NumberWrong >= 2) Console.Write("     |");
            if (NumberWrong == 9) Console.Write("   \\");
            else if (NumberWrong == 10) Console.Write("       / \\");
            else if (NumberWrong == 11) Console.Write("      _/ \\");
            else if (NumberWrong == 12) Console.Write("      _/ \\_");
            Console.WriteLine();
            if (NumberWrong >= 2) Console.WriteLine("     | "); else Console.WriteLine();
            if (NumberWrong >= 2) Console.WriteLine("     | "); else Console.WriteLine();
            if (NumberWrong >= 1) Console.WriteLine(" ----------   "); else Console.WriteLine();
            if (NumberWrong == 12) Console.WriteLine("HUNG HUNG HUNG HUNG HUNG");
        }

    }
}
