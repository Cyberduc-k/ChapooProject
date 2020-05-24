using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Item
    {
        public int Id { get; }
        public string Name { get; }
        public double Price { get; }
        public int NumberInStock { get; }

        public Item(int id, string name, double price, int numberInStock)
        {
            Id = id;
            Name = name;
            Price = price;
            NumberInStock = numberInStock;
        }
    }
}
