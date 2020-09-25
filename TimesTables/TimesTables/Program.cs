using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesTables
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplier;
            

            Console.Write("Enter a number: ");
            while (int.TryParse(Console.ReadLine(), out multiplier) == false)
            {
                Console.WriteLine("invalid Value entered, try again.");
                int.TryParse(Console.ReadLine(), out multiplier);
            }

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(multiplier * i);
            }

            AnyKey();
        }
        static void AnyKey()
        {
            Console.WriteLine("Press Any Key to continue...");
            Console.ReadKey();
        }

    }
}
