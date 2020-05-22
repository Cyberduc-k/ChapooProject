using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Drink_DAO : Base
    {
        public List<Drink> GetAll()
        {
            // @TODO
            string query = "";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadDrinks(ExecuteSelectQuery(query, parameters));
        }

        private List<Drink> ReadDrinks(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dataRow in dataTable.Rows)
                drinks.Add(ReadDrink(dataRow));

            return drinks;
        }

        private Drink ReadDrink(DataRow dataRow)
        {
            // @TODO
            return null;
        }
    }
}
