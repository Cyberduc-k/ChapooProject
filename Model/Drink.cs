using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Drink : Item
    {
        public bool Alcoholic { get; }

        public Drink(int id, string name, bool alcoholic, double price, int stock) : base(id, name, price, stock)
        { 
            Alcoholic = alcoholic;
        }

        //A constructor for when an ID isnt neccesary
        public Drink(string name, bool alcoholic, double price, int stock) : base(name, price, stock)
        {
            Alcoholic = alcoholic;
        }

        public Drink() : base() { }

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
