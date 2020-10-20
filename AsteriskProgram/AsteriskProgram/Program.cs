using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteriskProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int numOfRows;

            TitlePage();
            numOfRows = GetNumOfRows();
            DisplayTriangleImproved(numOfRows);
            AnyKey();
        }

        static void TitlePage()
        {
            Console.WriteLine("Triangle Simple");
            Console.WriteLine("***************");
        }

        static bool ValidateInt(ref int output, string input)
        {
            if(int.TryParse(input, out output))
            {
                return true;
            }

            return false;
        }

        static int GetNumOfRows()
        {
            int numOfRows = 0;

            Console.Write("Enter number of Rows: ");
            while(!ValidateInt(ref numOfRows, Console.ReadLine()))
            {
                Console.Write("Invalid input, try again: ");
            }
            return numOfRows;
        }

        static void DisplayTriangleSimple(int numOfRows)
        {

            for (int i = 0; i < numOfRows; i++)
            {
                Console.Write(" ".PadLeft(numOfRows - i));
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void DisplayTriangleImproved(int numOfRows)
        {
            for (int i = 0; i < numOfRows; i++)
            {
                Console.Write(" ".PadLeft(numOfRows - i));
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void AnyKey()
        {
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadKey();
        }
    }
}
