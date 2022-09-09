using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    internal class Snack
    {
        private string item;
        private byte index;
        private int price;
        public string Item { get { return item; } }
        public byte Index { get { return index; } }
        public int Price { get { return price; } }
        public Snack(string item, byte index, int price)
        {
            this.item = item;
            this.index = index;
            this.price = price;
        }   
    }
}
