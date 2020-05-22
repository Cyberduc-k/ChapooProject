using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Dish_DAO : Base
    {
        public List<Dish> GetAll()
        {
            // @TODO
            string query = "";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadDishes(ExecuteSelectQuery(query, parameters));
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
