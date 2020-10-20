using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 2, 4, 7, 7, 1 };

            array[4] = array[4] + 2;
            array[3] = array[3] - 1;
            array[5] = array[5]--;
            array[2] = 6;
            array[4] = array[1] * 2;
            array[1] = 1;
            array[2] = array[1] % 2;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
