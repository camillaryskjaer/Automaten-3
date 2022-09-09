using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    internal class VendingMachine
    {
        public List<Snack> snacks = new List<Snack>();
        Snack cola = new Snack("Cola", 1, 15);
        Snack mars = new Snack("Mars bar", 2, 10);
        Snack fanta = new Snack("Fanta", 3, 15);
        Snack sprite = new Snack("Sprite", 4, 15);
        Snack chipsBBQ = new Snack("BBQ chips", 5, 20);
        Snack snickers = new Snack("Snickers", 6, 10);

        public void Test()
        {
            snacks.Add(cola);
            snacks.Add(mars);
            snacks.Add(fanta);
            snacks.Add(sprite);
            snacks.Add(chipsBBQ);
            snacks.Add(snickers);
            foreach (Snack sn in snacks)
            {
                Console.WriteLine("Item: " + sn.Item + "\nIndexNumber: " + sn.Index + "\nPrice: " + sn.Price);
                Console.WriteLine("");
            }
        }
    }

}
