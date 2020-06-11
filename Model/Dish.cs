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
        public string Ingredients { get; }
        public DishCategory Category { get; }

        public Dish(int id, string name, string description, string ingredients, double price, int stock, DishCategory category) : base(id, name, price, stock)
        {
            Description = description;
            Ingredients = ingredients;
            Category = category;
        }

        //Constructor for when an ID isn't necessary
        public Dish(string name, string description, string ingredients, double price, int stock, DishCategory category) : base(name, price, stock)
        {
            Description = description;
            Ingredients = ingredients;
            Category = category;
        }

        public Dish() : base() { }
    }
}
