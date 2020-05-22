using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bill
    {
        public int ID { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public double Price { get; }
        public Medewerker medewerker { get; }
        public Tafel tafel { get; }
	public Dish dish { get; }
	public Drink drink { get; }

        public Bill(int iD, string firstName, string lastName, double price, Medewerker medewerker, Tafel tafel, Dish dish, Drink drink)
        {
            	ID = iD;
            	FirstName = firstName;
            	LastName = lastName;
            	Price = price;
            	Medewerker = medewerker;
            	Tafel = tafel;
		Dish = dish;
		Drink = drink;
        }
    }
}
