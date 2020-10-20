using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[12, 12];

            // Fill Array

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    matrix[i, j] = (i + 1) * (j + 1);
                    matrix[j, i] = (j + 1) * (i + 1);
                }
            }

            // Display

            Console.WriteLine("Times Tables Matrix");
            Console.WriteLine("*******************");

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }

            AnyKey();
        }
        static void AnyKey()
        {
            Console.WriteLine("Press Any 2 Keys to Continue....");
            Console.ReadKey();
            Console.ReadKey();
        }

    }
}
