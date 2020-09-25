using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum;
            int numTotals = 0;
            int average = 0;
            int count = 0; // amount of numbers entered. 

            Console.Write("Entre a number: ");
            while (int.TryParse(Console.ReadLine(), out userNum) == false)
            {
                Console.WriteLine("invalid Value entered, try again.");
                int.TryParse(Console.ReadLine(), out userNum);
            }

            while (userNum != -999)
            {
                count++;
                numTotals = numTotals + userNum;

                Console.Write("Entre another number: ");
                while (int.TryParse(Console.ReadLine(), out userNum) == false)
                {
                    Console.WriteLine("invalid Value entered, try again.");
                    int.TryParse(Console.ReadLine(), out userNum);
                }

            }

            average = numTotals / count;

            Console.WriteLine("The average is {0}.", average);

            AnyKey();
        }

        static void AnyKey()
        {
            Console.WriteLine("Press Any Key to continue...");
            Console.ReadKey();
        }

    }
}
