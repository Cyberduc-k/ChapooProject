using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Dish : Item
    {
        public string Description { get; }
        public List<string> Ingredients { get; }

        public Dish(string name, double price, int numberInStock, string description, List<string> ingredients) : base(name, price, numberInStock)
        {
            Description = description;
            Ingredients = ingredients;
        }
    }
}
