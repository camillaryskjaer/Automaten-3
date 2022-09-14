using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automaten.Products;

namespace Automaten
{
    internal class VendingMachine
    {
        public List<Product> products = new List<Product>();
        Product cola = new Drink("Cola", 1, 15);
        Product mars = new Snack("Mars bar", 2, 10);
        Product fanta = new Drink("Fanta", 3, 15);
        Product sprite = new Drink("Sprite", 4, 15);
        Product chipsBBQ = new Snack("BBQ chips", 5, 20);
        Product snickers = new Snack("Snickers", 6, 10);

        //Din vendingmaskine må ikke kende til din UI
        GUI gui = new GUI();

        public void Stock(List<Product> products)
        {
            foreach (Product sn in products)
            {
                
                //Dette hører til i UI laget
                Console.WriteLine("Item: " + sn.Item + "\nIndex: " + sn.Index + "\nPrice: " + sn.Price);
                Console.WriteLine("");
            }
        }
        public void Test()
        {
            products.Add(cola);
            products.Add(fanta);
            products.Add(sprite);
            products.Add(chipsBBQ);
            products.Add(snickers);
            products.Add(mars);

            gui.Menu(products);
        }
        
    }
}
