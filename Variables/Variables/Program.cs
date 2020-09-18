using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            /* Demo Program showing variables 
             and datatypes
             15/09/2020*/

            byte gcsesTaken = 12;
            int capacity = 45645;
            float exchangeRate = 3.4F;
            DateTime date = DateTime.Parse("16 / 9 / 2014");
            bool lottoWinner = true;
            string countryName = "France";
            char gender = 'F';
            sbyte temperature = -26;
            string phoneNum = "01624 693500";
            string postCode = "IM9 1RE";
            double pi = Math.PI;

            //Display Variables
            ChangeColor();
            Console.WriteLine("Number of GCSEs Taken = {0}", gcsesTaken);
            Console.WriteLine("Capacity = {0}", capacity);
            Console.WriteLine("Exchange Rate = {0}", exchangeRate);
            Console.WriteLine("Date = {0}", date);
            Console.WriteLine("Lottery Winner = {0}", lottoWinner);
            Console.WriteLine("Country Name = {0}", countryName);
            Console.WriteLine("Gender = {0}", gender);
            Console.WriteLine("Temperature = {0}", temperature);
            Console.WriteLine("Phone Number = {0}", phoneNum);
            Console.WriteLine("Post Code = {0}", postCode);
            Console.WriteLine("Pi = {0}", pi);

            PressAnyKey();
        }

        static void ChangeColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
        }

        static void PressAnyKey()
        {
            Console.WriteLine("Press Any Key to continue...");
            Console.ReadKey();
        }
    }

}
