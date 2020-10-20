using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayYourCardsRight
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Define Variables
            Random rnd = new Random(); //creates random number generator
            int[] cards = new int[7];
            string[] players = new string[2];
            char guess;
            int currentPlayer;
            bool winner = false;

            //Get Player Names
            Console.WriteLine("Play Your Cards Right");
            Console.WriteLine("=====================\n");
            Console.WriteLine("Enter the names of the players...");
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Player {0}: ", i + 1);
                players[i] = Console.ReadLine();
            }

            //Decide who goes first
            currentPlayer = rnd.Next(0, 2);
            Console.WriteLine("{0} will go first.\n", players[currentPlayer]);
            Console.WriteLine("Press any key to play...");
            Console.ReadKey();

            //Play the Game
            do
            {
                bool play = true;
                int count = 1;

                //Initialise Array
                for (int i = 0; i < 7; i++)
                {
                    cards[i] = rnd.Next(1, 14);
                }

                //Start the round
                Console.Clear();
                Console.WriteLine("{0} Play Your Cards Right!!", players[currentPlayer]);
                Console.WriteLine();

                while (play == true)
                {
                    //Display the cards
                    Console.Write("Your cards are: ");
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write(cards[i].ToString().PadLeft(3));
                    }
                    Console.WriteLine("???".PadLeft(4));
                    Console.WriteLine();

                    //Ask for the players guess
                    Console.WriteLine("Is the next card Higher (h) or Lower (l) than a {0}?", cards[count - 1]);
                    guess = char.Parse(Console.ReadLine());

                    //See if the player guessed correctly
                    if ((guess == 'h' & cards[count - 1] < cards[count]))
                    {
                        Console.WriteLine("Correct, the next card was a {0}!", cards[count]);
                        count++;
                    }
                    else if (guess == 'l' & cards[count - 1] > cards[count])
                    {
                        Console.WriteLine("Correct, the next card was a {0}!", cards[count]);
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, the next card was a {0}!", cards[count]);
                        play = false;
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }

                    //Check to see if the player has got to the end
                    if (count == 7)
                    {
                        play = false;
                        winner = true;

                        //Output the winner
                        Console.WriteLine("\n******************");
                        Console.WriteLine("WE HAVE A WINNER!!");
                        Console.WriteLine("******************\n");
                        Console.WriteLine("Congratulations {0}, You have finally played your cards right!", players[currentPlayer]);
                        Console.WriteLine();
                    }
                }

                //Change the player
                if (currentPlayer == 0) currentPlayer = 1;
                else currentPlayer = 0;

            } while (winner == false);

            //End the program
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}