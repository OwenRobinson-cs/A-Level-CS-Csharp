using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheThimble
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define Variables

            string[,] grid = new string[10, 10];
            Random RNG = new Random();
            int thimbleX;
            int thimbleY;
            int userX;
            int userY;
            double distanceX = 0, distanceY = 0;
            bool thimbleFound = false;
            bool player2 = false;
            int guesses = 0;

            // Get Thimble Location
            thimbleX = RNG.Next(0, 9);
            thimbleY = RNG.Next(0, 9);
            
            /* Fill grid with blanks */
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    grid[i, j] = " ";
                }
            }

            
            // GAME
                while (!thimbleFound)
            {
                guesses++;
                BuildGrid(grid, player2);
                // Get User Input 

                Console.WriteLine("Enter X Coordinate: ");
                while (int.TryParse(Console.ReadLine(), out userX) == false || userX > 10 || userX < 1)
                {
                    Console.WriteLine("Invalid Value entered, try again.");
                }
                Console.WriteLine("Enter Y Coordinate: ");

                while (int.TryParse(Console.ReadLine(), out userY) == false || userY > 10 || userY < 1)
                {
                    Console.WriteLine("Invalid Value entered, try again.");
                }

                // Store location in Grid 
                userX--;
                userY--;
                if (player2)
                {
                    grid[userY, userX] = "O";
                }
                else
                {
                    grid[userY, userX] = "X";
                }

                // Compare to Thimble Location
                Console.Clear(); // Clear Console

                // Calculate Distances

                distanceX = thimbleX - userX;
                distanceY = thimbleY - userY;

                if (userX == thimbleX && userY == thimbleY)
                {
                    thimbleFound = true;
                    grid[thimbleX, thimbleY] = "*";
                }
                else if (Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY)) <= 1)
                {
                    Console.WriteLine("Hot");
                }
                else if (Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY)) <= 3)
                {
                    Console.WriteLine("Warm");
                }
                else if (Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY)) <= 7)
                {
                    Console.WriteLine("Cold");
                }
                else
                {
                    Console.WriteLine("Sub Zero");
                }




                // Switch player
                if (player2)
                {
                    player2 = false;

                }
                else
                {
                    player2 = true;
                }
            }


                //Output win message
                if (!player2)
            {
                Console.WriteLine("Correct Guess, Player 1 wins.");
            }
                else
            {
                Console.WriteLine("Correct Guess, Player 2 wins.");
            }
            Console.WriteLine("{0} guesses were made.", guesses);
            AnyKey();
        }

        static void AnyKey()
        {
            Console.WriteLine("Press Any 2 Keys to Continue....");
            Console.ReadKey();
            Console.ReadKey();
        }
        static void BuildGrid(string[,] grid, bool player2)
        {
            // Output New Grid 
            if (player2)
            {
                Console.WriteLine("Player 2's turn");
            }
            else
            {
                Console.WriteLine("Player 1's turn");
            }

            Console.Write("     |");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}   |".PadLeft(2), i + 1);
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("________________________________________________________");
                Console.Write((i + 1).ToString().PadLeft(2));
                Console.Write("|".PadLeft(4));
                for (int j = 0; j < 10; j++)
                {

                    Console.Write(grid[i, j]);
                    Console.Write("|".PadLeft(4));
                }
                Console.WriteLine();
            }
        }

        double CalculateDistance()
        {
            double output = 0;

            return output;
        }
    }
}
