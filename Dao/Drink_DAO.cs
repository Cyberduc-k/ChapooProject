using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Drink_DAO : Base
    {      
        // Get a list of all the drinks
        public List<Drink> GetAll()
        {
            // @TODO
            string query = "";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Add a new drink to the database
        public void Add(Drink drink)
        {
            // @TODO
        }

        // Remove a drink from the database
        public void Remove(Drink drink)
        {
            // @TODO
        }

        // Modify the properties of a drink in the database
        public void Modify(Drink drink)
        {
            // @TODO
        }

        // Convert the raw database data into a list of Drink objects
        private List<Drink> ReadAll(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dataRow in dataTable.Rows)
                drinks.Add(Read(dataRow));

            return drinks;
        }

        // Convert the raw database data into a Drink object
        private Drink Read(DataRow dataRow)
        {
            // @TODO
            return null;
        }
    }
}
