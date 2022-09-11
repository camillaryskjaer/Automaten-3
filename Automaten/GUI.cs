using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automaten.Products;

namespace Automaten
{
    internal class GUI
    {
        private bool exit = false;
        public void Menu(List<Product> products)
        {
            
            VendingMachine machine = new VendingMachine();

            do
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------------------------------------------\n");
                Console.WriteLine("                                    Vending machine");
                Console.WriteLine("\n---------------------------------------------------------------------------------");
                Console.WriteLine("1. buy an item");
                Console.WriteLine("2. Contact admin");
                Console.WriteLine("3. Show stock");
                Console.WriteLine("4. Exit");
                Console.Write("Enter an option: ");


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
                        Console.Write("Enter an option: ");
                        choice = Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("Enter password: ");
                        string adminPassword = Console.ReadLine();
                        if (adminPassword == "1234")
                        Console.WriteLine("---------------------------------------------------------------------------------\n");
                        Console.WriteLine("                                        Admin Menu");
                        Console.WriteLine("\n---------------------------------------------------------------------------------");
                        Console.WriteLine("1. Restock");
                        Console.WriteLine("2. take money");
                        choice = Console.ReadKey();
                        switch (choice.Key)
                        {
                            case ConsoleKey.D1:
                                break;
                            case ConsoleKey.D2:
                                break;
                            default:
                                break;
                        }
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        machine.Stock(products);
                        Thread.Sleep(20000);
                        break;
                    case ConsoleKey.D4:
                        exit = true;
                        break;
                    default:
                        break;
                }   
                
            } while (exit != true);
        }
    }
}