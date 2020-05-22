using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Dish_DAO : Base
    {
        //Get a list of all the dishes
        public List<Dish> GetAll()
        {
            // @TODO
            return null;
        }

        //Add a new dish to the database
        public void AddDishk(Dish dish)
        {
            // @TODO
        }

        //Remove a dish from the database
        public void RemoveDish(Dish dish)
        {
            // @TODO
        }

        //Modify the properties of a dish in the database
        public void ModifyDish(Dish dish)
        {
            // @TODO
        }

        private List<Dish> ReadDishes(DataTable dataTable)
        {
            List<Dish> dishes = new List<Dish>();

            foreach (DataRow dataRow in dataTable.Rows)
                dishes.Add(ReadDish(dataRow));

            return dishes;
        }

        private Dish ReadDish(DataRow dataRow)
        {
            // @TODO
            return null;
        }
    }
}
