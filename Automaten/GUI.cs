using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    internal class GUI
    {
        public void Menu(List<Snack> snacks)
        {
            Console.WriteLine("---------------------------------------------------------------------------------\n");
            Console.WriteLine("                                    Vending machine");
            Console.WriteLine("\n---------------------------------------------------------------------------------");
            Console.WriteLine("1. buy an item");
            Console.WriteLine("2. Contact admin");
            Console.WriteLine("3. Show layer");

            ConsoleKeyInfo choice;
            choice = Console.ReadKey();
            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("---------------------------------------------------------------------------------\n");
                    Console.WriteLine("                                        Menu");
                    Console.WriteLine("\n---------------------------------------------------------------------------------");
                    Console.WriteLine("buy an item");
                    Console.WriteLine("1. Cola - 15kr");
                    Console.WriteLine("2. Mars bar - 10kr");
                    Console.WriteLine("3. Fanta - 15kr");
                    Console.WriteLine("4. sprite - 15kr");
                    Console.WriteLine("5. BBQ Chips - 20kr");
                    Console.WriteLine("6. Snickers - 10kr");
                    Console.Write("Indtast et index nummner: ");
                    choice = Console.ReadKey();
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                default:
                    break;
            }
            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    snacks.Remove(snacks[1]);
                    break;
            }
        }
    }
}