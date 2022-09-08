using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    internal class VendingMachine : Snacks
    {
        public void Vend()
        {
            List<Snacks> snacks = new List<Snacks>();
            snacks.Add(new Snacks())
            ConsoleKeyInfo choice;
            choice = Console.ReadKey();
            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                case ConsoleKey.D4:
                    break;
                case ConsoleKey.D5:
                    break;
                case ConsoleKey.D6:
                    break;
                default:
                    break;
            }
        }
    }
}
