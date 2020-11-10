using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace YachtProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define Variables
            string name;
            string address;
            int initalCost;
            int totalCost;
            string selectedExtras;

            // Display Name
            DisplayName();
            // Get the Details 
            GetDetails(out name, out address);
            YachtDetails(out initalCost, out totalCost, out selectedExtras);

            // Display Selection
            DisplaySelection(name, address, initalCost, totalCost, selectedExtras);

            Console.ReadLine();
        }

        static void DisplayName()
        {
            Console.Clear();
            Console.WriteLine("Dream Lives");
            Console.WriteLine("===========\n");
        }

        static void GetDetails(out string name, out string address)
        {
            name = GetName();
            address = GetAddress();
        }

        static string GetName()
        {
            string output;

            do
            {
                Console.Write("Enter Name: ");
                output = Console.ReadLine();
            } while (output == null);

            return output;
        }

        static string GetAddress()
        {
            string output;

            do
            {
                Console.Write("Enter Address, use commas to seperate lines: ");
                output = Console.ReadLine();
            } while (output == null);

            return output;
        }

        static void YachtDetails(out int initalCost, out int cost, out string extrasSelected)
        {
            int length = GetLength();
            bool loopExtrasMenu = false;
            char extrasInput;
            bool extra1 = false, extra2 = false, extra3 = false, extra4 = false, extra5 = false;
            int extraSelection;
            extrasSelected = "";
            initalCost = CalculateInitalCost(length);
            cost = initalCost;
            Console.WriteLine("The Inital Cost is: £{0}", initalCost);
            Console.WriteLine("Would you like any extras? Y/N");
            while (!char.TryParse(Console.ReadLine().ToLower(), out extrasInput) || extrasInput != 'y' && extrasInput != 'n')
            {
                Console.WriteLine("Error");
            }
            if (extrasInput == 'y')
            {
                loopExtrasMenu = true;
            }
            while (loopExtrasMenu)
            {
                Console.WriteLine("Extras: \n1) Swimming Pool (£1,500,000 / £700,000) \n2) Helicopter Pad (£3,250,000) \n3) Gold Plated Finishing (£999,000) \n4) Room to park your car (£2,000,000) \n5) Submarine (£20,000,000)");
                while (!int.TryParse(Console.ReadLine(), out extraSelection) || extraSelection > 5 || extraSelection < 1)
                {
                    Console.WriteLine("Input invalid, re-enter below: ");
                }

                switch (extraSelection)
                {
                    case 1:
                        if (!extra1)
                        {
                            extra1 = true;
                            cost += GetPoolCost();
                            extrasSelected += "Swimming Pool\n";
                        }
                        else
                        {
                            Console.WriteLine("Error, Option already selected, no charge added.");
                        }
                        break;
                    case 2:
                        if (!extra2)
                        {
                            extra2 = true;
                            cost += 3250000;
                            extrasSelected += "Helicopter Pad\n";
                        }
                        else
                        {
                            Console.WriteLine("Error, Option already selected, no charge added.");
                        }
                        break;
                    case 3:
                        if (!extra3)
                        {
                            extra3 = true;        
                            if (length == 20)
                            {
                                initalCost += 999000;
                            }
                            else
                            {
                                cost += 999000 + (20000 * (length - 20));
                            }
                            extrasSelected += "Gold Plated Finishing\n";
                        }
                        else
                        {
                            Console.WriteLine("Error, Option already selected, no charge added.");
                        }
                        break;
                    case 4:
                        if (length > 50)
                        {
                            if (!extra4)
                            {
                                extra4 = true;
                                cost += 2000000;
                                extrasSelected += "Room to park your car\n";
                            }
                            else
                            {
                                Console.WriteLine("Error, Option already selected, no charge added.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error, Yacht Too small.");
                        }
                        break;
                    case 5:
                        if (length == 60)
                        {
                            if (!extra5)
                            {
                                extra5 = true;
                                cost += 20000000;
                                extrasSelected += "Submarine\n";
                            }
                            else
                            {
                                Console.WriteLine("Error, Option already selected, no charge added.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error, Yacht Too small.");
                        }
                        break;
                }

                Console.WriteLine("Would you like to select another extra? Y/N");
                while (!char.TryParse(Console.ReadLine().ToLower(), out extrasInput) || extrasInput != 'y' && extrasInput != 'n')
                {
                    Console.WriteLine("Error");
                }
                if (extrasInput == 'n')
                {
                    loopExtrasMenu = false;
                }
            }
            if (extrasSelected == "")
            {
                extrasSelected = "None";
            }
        }

        static int GetPoolCost()
        {
            char userResponse; 
            Console.WriteLine("Large or Small? L/S");
            while (!char.TryParse(Console.ReadLine().ToLower(), out userResponse) || userResponse != 'l' && userResponse != 's')
            {
                Console.WriteLine("Error");
            }
            if (userResponse == 'l')
            {
                return 1500000;
            }
            else
            {
                return 700000;
            }
        }
        static int GetLength()
        {
            int output;
            Console.Write("Enter Yacht Length (20-60m): ");
            while (!int.TryParse(Console.ReadLine(), out output) || output > 60 || output < 20)
            {
                Console.WriteLine("Input invalid, re-enter below: ");
            }
            return output;
        }

        static int CalculateInitalCost(int length)
        {
            int cost = 35000000;
            if (length > 20)
            {
                cost += (3000000 * (length - 20));
            }
            return cost;
        }

        static void DisplaySelection(string name, string address, int initalCost, int totalCost, string selectedExtras)
        {
            DisplayName();

            // Display Customer info
            Console.WriteLine("Customer Information: ");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Address: {0}", address);


            // Display Yacht Details
            Console.WriteLine("\n\nYacht Details");
            Console.WriteLine("Inital Price: {0}", initalCost);
            Console.WriteLine("Selected Extras: {0}", selectedExtras);
            Console.WriteLine();
            Console.WriteLine("Total Cost: {0}", totalCost);

        }
    }
}
