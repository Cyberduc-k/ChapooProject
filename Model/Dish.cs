using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Dish
    {
        public string Name { get; }
        public string Description { get; }
        public List<string> Ingredients { get; }
        public double Price { get; }
        public int NumberInStock { get; }
    }
}
