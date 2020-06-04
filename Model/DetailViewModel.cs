using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DetailViewModel
    {
        public Dish Dish { get; set; }
        public Drink Drink { get; set; }

        public DetailViewModel(Dish dish, Drink drink)
        {
            Dish = dish;
            Drink = drink;
        }
    }
}
