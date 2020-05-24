using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Drink
    {
        public int Id { get; }
        public string Name { get; }
        public bool Alcoholic { get; }
        public double Price { get; }
        public int Stock { get; }

        public Drink(int id, string name, double price, int numberInStock, bool alcoholic) : base(id, name, price, numberInStock)
        {
            Id = id;
            Name = name;
            Alcoholic = alcoholic;
            Price = price;
            Stock = stock;
        }
    }
}
