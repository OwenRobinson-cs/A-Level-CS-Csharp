using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paramaters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Times Table Program");
            Console.WriteLine("===================\n");
            try
            {
                Console.WriteLine("Enter Times Table");
                TimesTables(int.Parse(Console.ReadLine()));
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("An Error Occured");
                PressAnyKey();
            }
        }

        static void TimesTables(int input)
        {
            for (int i = 0; i <= 12; i++)
            {
                Console.Write(i.ToString().PadLeft(2));
                Console.Write(" x {0}  =", input);
                Console.WriteLine("{0}".PadLeft(4), i * input);
            }
            PressAnyKey();
        }

        static void PressAnyKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
