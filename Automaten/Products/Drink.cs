using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Products
{
    internal class Drink : Product
    {
        public Drink(string item, byte index, int price)
        {
            this.item = item;
            this.index = index;
            this.price = price;
        }
        private string item;
        private byte index;
        private int price;

        internal string Item { get { return item; } set { item = value; } }
        internal byte Index { get { return index; } }
        internal int Price { get{ return price; } set { price = value; } }
    }
}
