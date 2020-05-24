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

        public Drink(int id, string name, double price, int numberInStock, bool alcoholic) : base(id, name, price, numberInStock)
        {
            Alcoholic = alcoholic;
        }
    }
}
