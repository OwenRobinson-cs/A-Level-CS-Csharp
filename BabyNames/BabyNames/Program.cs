using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] babyNames = { "Oliver", "Muhammad", "Noah", "Harry", "Jack", "Olivia", "Lily", "Sophia", "Emily", "Amelia", "Ava", "Isla", "Isabella", "Isabelle", "Sophie", "Ella", "Mia", "Poppy", "Evie", "Charlotte", "Charlie", "Jacob", "George", "Ethan", "Henry", "Oscar", "James", "Joshua", "Freddie", "Leo" };
            string userName = GetName();

            if (CompareNames(userName, babyNames))
            {
                Console.WriteLine("Name is on the list of popular baby names.");
            }
            else
            {
                Console.WriteLine("Name is not on the list of popular baby names.");
            }
            Console.ReadKey();
        }

        static string GetName()
        {
            Console.Write("Enter name: ");
            return Console.ReadLine();
        }

        static bool CompareNames(string userName, string[] babyNames)
        {
            for (int i = 0; i < babyNames.Length; i++)
            {
                if (userName == babyNames[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
