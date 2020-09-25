using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum;
            int max = 0;
            int min;

            Console.Write("Entre a number: ");
            while (int.TryParse(Console.ReadLine(), out userNum) == false)
            {
                Console.WriteLine("invalid Value entered, try again.");
                int.TryParse(Console.ReadLine(), out userNum);
            }

            if (userNum != -999)
            {
                min = userNum;
            }
            else
            {
                min = 0;
            }

            while (userNum != -999)
            {
                if (userNum > max)
                {
                    max = userNum;
                }

                if (userNum < min)
                {
                    min = userNum;
                }

                Console.Write("Entre another number: ");
                while (int.TryParse(Console.ReadLine(), out userNum) == false)
                {
                    Console.WriteLine("invalid Value entered, try again.");
                    int.TryParse(Console.ReadLine(), out userNum);
                }
            }

            Console.WriteLine("The maximum number is {0}.\n The minimum number is {1}", max, min);

            AnyKey();
        }

        static void AnyKey()
        {
            Console.WriteLine("Press Any Key to continue...");
            Console.ReadKey();
        }

    }
}
