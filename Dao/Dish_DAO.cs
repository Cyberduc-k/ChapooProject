using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Dish_DAO : Base
    {
        // Get a list of all the dishes
        public List<Dish> GetAll()
        {
            // @TODO
            string query = "";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Add a new dish to the database
        public void Add(Dish dish)
        {
            // @TODO
        }

        // Remove a dish from the database
        public void Remove(Dish dish)
        {
            // @TODO
        }

        // Modify the properties of a dish in the database
        public void Modify(Dish dish)
        {
            // @TODO
        }

        // Convert the raw database data into a list of Dish objects
        private List<Dish> ReadAll(DataTable dataTable)
        {
            List<Dish> dishes = new List<Dish>();

            foreach (DataRow dataRow in dataTable.Rows)
                dishes.Add(Read(dataRow));

            return dishes;
        }

        // Convert the raw database data into an Dish object
        private Dish Read(DataRow dataRow)
        {
            // @TODO
            return null;
        }
    }
}
