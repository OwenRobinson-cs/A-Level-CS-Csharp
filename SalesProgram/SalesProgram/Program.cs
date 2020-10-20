using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define Arrays
            string[] salesTeam = { "Dave", "Sarah", "Juan", "Gilno" };
            int[,] salesData = new int[13, salesTeam.Length];
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            string bestSalesPerson = "";
            int highestSales = 0;
            int average = 0;
            // Get Sales Info

            for (int i = 0; i < salesTeam.Length; i++)
            {
                Console.WriteLine("Enter Sales Info for {0}:", salesTeam[i]);
                for (int j = 0; j < 12; j++)
                {
                    Console.Write("{0}: ", months[j]);
                    while (int.TryParse(AutoGenerator().ToString(), out salesData[j, i]) == false)
                    {
                        Console.WriteLine("Invalid Value entered, try again.");
                    }
                    Console.WriteLine();
                }
                
            }

            // Calculate Totals 

            GetTotals(salesTeam, ref salesData);

            // Calculate Averages

            for (int i = 0; i < salesTeam.Length; i++)
            {
                average += salesData[12, i];
            }
            average /= 48;

            // Calculate Best SalesPerson

            for (int i = 0; i < salesTeam.Length; i++)
            {
                if (salesData[12, i] > highestSales)
                {
                    bestSalesPerson = salesTeam[i];
                    highestSales = salesData[12, i];
                }
            }

            Console.WriteLine();

            // Display Sales Data

            // months
            Console.Write("          "); // Space before start of months;
            for (int i = 0; i < months.Length; i++)
            {
                Console.Write(months[i].PadLeft(4));
            }
            Console.WriteLine("Tot".PadLeft(4));


            for (int i = 0; i < salesTeam.Length; i++)
            {
                Console.Write(salesTeam[i].PadLeft(10));
                for (int j = 0; j < 13; j++)
                {
                    Console.Write(salesData[j, i].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }

            Console.WriteLine("The best sales person was {0}", bestSalesPerson);
            AnyKey();


        }

        static void AnyKey()
        {
            Console.WriteLine("Press Any 2 Keys to Continue....");
            Console.ReadKey();
            Console.ReadKey();
        }

        static void GetTotals(string[] salesTeam, ref int[,] salesData)
        {
            for (int i = 0; i < salesTeam.Length; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    salesData[12, i] = salesData[12, i] + salesData[j, i];
                }
            }
        }

        static string GetBestSales(int[] salesTeam)
        {
            string best = "";
            int highestSales = 0;
            for (int i = 0; i < salesTeam.Length; i++)
            {
                if (salesData[12, i] > highestSales)
                {
                    bestSalesPerson = salesTeam[i];
                    highestSales = salesData[12, i];
                }
            }
            return best;
        }

        
        static int AutoGenerator()
        {
            Random RNG = new Random();
            return RNG.Next(1, 26);
        }
    }


}
