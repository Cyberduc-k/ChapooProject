using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Bill_DAO : Base
    {
        // Get a list of all the billes
        public List<Bill> GetAll()
        {
            // @TODO
            string query = "";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Add a new bill to the database
        public void Add(Bill bill)
        {
            // @TODO
        }

        // Remove a bill from the database
        public void Remove(Bill bill)
        {
            // @TODO
        }

        // Modify the properties of a bill in the database
        public void Modify(Bill bill)
        {
            // @TODO
        }

        // Convert the raw database data into a list of Bill objects
        private List<Bill> ReadAll(DataTable dataTable)
        {
            List<Bill> bills = new List<Bill>();

            foreach (DataRow dataRow in dataTable.Rows)
                bills.Add(Read(dataRow));

            return bills;
        }

        // Convert the raw database data into an Bill object
        private Bill Read(DataRow dataRow)
        {
            // @TODO
            return null;
        }
    }
}