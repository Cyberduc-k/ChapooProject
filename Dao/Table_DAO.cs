using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Table_DAO : Base
    {
        // Get a list of all the tables
        public List<Table> GetAll()
        {
            // @TODO
            string query = "";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Add a new table to the database
        public void Add(Table table)
        {
            // @TODO
        }

        // Remove a drink from the database
        public void Remove(Table table)
        {
            // @TODO
        }

        // Modify the properties of a drink in the database
        public void Modify(Table table)
        {
            // @TODO
        }

        // Convert the raw database data into a list of Table objects
        private List<Table> ReadAll(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dataRow in dataTable.Rows)
                tables.Add(Read(dataRow));

            return tables;
        }

        // Convert the raw database data into a Table object
        private Table Read(DataRow dataRow)
        {
            // @TODO
            return null;
        }
    }
}
