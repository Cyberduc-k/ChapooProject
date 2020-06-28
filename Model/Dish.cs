using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Dish : Item
    {
        public string Description { get; set; }
        public string Ingredients { get; }
        public DishCategory Category { get; }

        public Dish(int id, string name, string description, string ingredients, double price, int stock, DishCategory category, bool finished, string comment, int aantal) : base(id, name, price, stock)
        {
            Description = description;
            Ingredients = ingredients;
            Category = category;
            Finished = finished;
            Comment = comment;
            Aantal = aantal;
        }

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

        #region Compare Override
        //This region is used to compare id's instead of the reference identity
        protected bool Equals(Dish other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            return Equals((Dish)obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
        #endregion
    }
}
