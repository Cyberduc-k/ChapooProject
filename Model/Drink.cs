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

        public Drink(int id, string name, bool alcoholic, double price, int stock)
        {
            Id = id;
            Name = name;
            Alcoholic = alcoholic;
            Price = price;
            Stock = stock;
        }

        //A constructor for when an ID isnt neccesary
        public Drink(string name, bool alcoholic, double price, int stock)
        {
            Name = name;
            Alcoholic = alcoholic;
            Price = price;
            Stock = stock;
        }

        public Drink() 
        {
            
        }

        public override string ToString()
        {
            if (Alcoholic)
            {
                return "Ja";
            }

            return "Nee";
        }
    }
}
