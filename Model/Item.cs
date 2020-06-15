using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //Base class for dishes and drinks
    public abstract class Item
    {
        public int Id { get; }
        public string Name { get; }
        public double Price { get; }
        public int Stock { get; set; }

        public Item(int id, string name, double price, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }

        public Item(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public Item() { }
    }
}
