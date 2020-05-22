using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;
using System.Configuration;

namespace Dao
{
    public class Drink_DAO : Base
    {      
        //Get a list of all the drinks
        public List<Drink> GetAll()
        {
            // @TODO
            return null;
        }

        //Add a new drink to the database
        public void AddDrink(Drink drink)
        {
            // @TODO
        }

        //Remove a drink from the database
        public void RemoveDrink(Drink drink)
        {
            // @TODO
        }

        //Modify the properties of a drink in the database
        public void ModifyDrink(Drink drink)
        {
            // @TODO
        }

        //Convert the raw database data into Drink object
        private List<Drink> ReadDrinks(DataTable dataTable)
        {
            // @TODO
            return null;
        }
    }
}
