using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            bool equal;
            bool largerThan;

            // Get Numbers
            // num1
            Console.WriteLine("Enter Number 1: ");
            num1 = GetNumber();

            // num2
            Console.WriteLine("Enter Number 2: ");
            num2 = GetNumber();

            // Compare
            equal = IsEqual(num1, num2);

            if (!equal)
            {
                largerThan = IsLargerThan(num1, num2);

                if (largerThan)
                {
                    Console.WriteLine("Number 1 is greater than Number 2.");
                }
                else
                {
                    Console.WriteLine("Number 2 is greater than Number 1.");
                }
            }
            else
            {
                Console.WriteLine("Numbers are equal.");
            }

            Console.ReadKey();
        }

        static int GetNumber()
        {
            int output;

            int.TryParse(Console.ReadLine(), out output);

            return output;
        }

        static bool IsEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsLargerThan(int num1, int num2)
        {
            if (num1 > num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
