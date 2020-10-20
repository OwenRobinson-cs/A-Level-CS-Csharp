using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainFallChart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            /* Rainfall Chart
             * Easy Programming
            */
            // Varables
            int[] rainFallData = new int[12];
            int total = 0;
            
            for (int i = 0; i < 12; i++)
            {
                Console.Write("Enter Month {0}: ", i + 1);
                while (int.TryParse(Console.ReadLine(), out rainFallData[i]) == false || rainFallData[i] < 0)
                {
                    Console.WriteLine("Invalid Value entered, try again.");
                }
                total = total + rainFallData[i];
                Console.WriteLine();
            }

            DisplayDataVertical(rainFallData, total);
            //DisplayData(rainFallData);
            AnyKey();
        }
        static void AnyKey()
        {
            Console.WriteLine("Press Any Key to Contine....");
            Console.ReadKey();
        }
        static void DisplayData(int[] rainFallData)
        {
            // Sneaky Variables
            int count = 1;

            Console.WriteLine("Rainfall Chart");
            Console.WriteLine("==============");

            for (int i = 0; i < rainFallData.Length; i++)
            {
                Console.Write("Month {0}:  ", count.ToString().PadLeft(3));
                for (int j = 0; j < rainFallData[i]; j++)
                {
                    Console.Write((char)1771);
                }
                Console.WriteLine();
                count++;
            }
        }
        static void DisplayDataVertical(int[] rainFallData, int total)
        {
            // Varaibles
            int max = CalcualateMax(rainFallData);
            int min = CalculateMin(rainFallData);
            int average = CalculateAverage(total, rainFallData);
            int currentLine = max;

            for (int j = 0; j < max; j++)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (rainFallData[i] >= currentLine)
                    {
                        Console.Write("  *  ");
                    }
                    else
                    {
                        Console.Write("     ");
                    }
                }
                currentLine--;
                Console.WriteLine();
            }
            Console.WriteLine("Jan  Feb  Mar  Apr  May  Jun  Jul  Aug  Sep  Oct  Nov  Dec");
            // Display all Calcualted Values (Max, Min, Avg, Total)
            Console.WriteLine("The Maximum Rainfall was: {0}", max);
            Console.WriteLine("The Minimum Rainfall was: {0}", min);
            Console.WriteLine("The Total Rainfall was: {0}", total);
            Console.WriteLine("The Average Rainfall was: {0}", average);
        }
        static int CalculateMin(int[] rainFallData)
        {
            int min = rainFallData[0];
            for (int i = 0; i < rainFallData.Length; i++)
            {
                if (rainFallData[i] < min)
                {
                    min = rainFallData[i];
                }
            }
            return min;
        }
        static int CalculateAverage(int total, int[] rainFallData)
        {
            int avg;

            avg = total / rainFallData.Length;

            return avg;
        }
        static int CalcualateMax(int[] rainFallData)
        {
            int max = 0;
            for (int i = 0; i < rainFallData.Length; i++)
            {
                if (rainFallData[i] > max)
                {
                    max = rainFallData[i];
                }
            }

            return max;
        }

    }
}