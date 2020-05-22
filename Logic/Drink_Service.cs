using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Model;

namespace Logic
{
    public class Drink_Service
    {
        Drink_DAO drink_db = new Drink_DAO();

        //Get a list of all the drinks from the DAO
        public List<Drink> GetAllDrinks()
        {
            return null;
        }

        //Add a new drink
        public void AddDrink(Drink drink)
        {

        }

        //Remove a drink
        public void RemoveDrink(Drink drink)
        {

        }

        //Modify the properties of a drink
        public void ModifyDrink(Drink drink)
        {

        }
    }
}
