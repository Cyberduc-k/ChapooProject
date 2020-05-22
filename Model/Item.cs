using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Item
    {
        public string Name { get; }
        public double Price { get; }
        public int NumberInStock { get; }

        public Item(string name, double price, int numberInStock)
        {
            Name = name;
            Price = price;
            NumberInStock = numberInStock;
        }
    }
}
