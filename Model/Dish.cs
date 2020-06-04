﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Dish
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string Ingredients { get; }
        public double Price { get; }
        public int Stock { get; }
        public DishCategory Category { get; }

        public Dish(int id, string name, string description, string ingredients, double price, int stock, DishCategory category)
        {
            Id = id;
            Name = name;
            Description = description;
            Ingredients = ingredients;
            Price = price;
            Stock = stock;
            Category = category;
        }

        //Constructor for when an ID isn't necessary
        public Dish(string name, string description, string ingredients, double price, int stock, DishCategory category)
        {
            Name = name;
            Description = description;
            Ingredients = ingredients;
            Price = price;
            Stock = stock;
            Category = category;
        }

        public Dish()
        {

        }
    }
}
