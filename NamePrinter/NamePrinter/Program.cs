using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamePrinter
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintName10();
            PressAnyKey();
        }

        static string GetName()
        {
            string name = null;
            while (name == null)
            {
                Console.Write("Enter name: ");
                name = Console.ReadLine();
            }
            return name;
        }

        static void PrintName10()
        {
            string name = GetName();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(name);
            }
        }

        static void PressAnyKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

    }
}
