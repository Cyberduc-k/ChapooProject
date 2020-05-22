using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Reservation_DAO : Base
    {
        // Get a list of all reservations
        public List<Reservation> GetAll()
        {
            // @TODO
            string query = "";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Add a new reservation to the database
        public void Add(Reservation reservation)
        {
            // @TODO
        }

        // Remove a reservation from the database
        public void Remove(Reservation reservation)
        {
            // @TODO
        }

        // Modify the properties of a reservation in the database
        public void Modify(Reservation reservation)
        {
            // @TODO
        }

        // Convert the raw database data into a list of Reservation objects
        private List<Reservation> ReadAll(DataTable dataTable)
        {
            List<Reservation> reservations = new List<Reservation>();

            foreach (DataRow dataRow in dataTable.Rows)
                reservations.Add(Read(dataRow));

            return reservations;
        }

        // Convert the raw database data into an Reservation object
        private Reservation Read(DataRow dataRow)
        {
            // @TODO
            return null;
        }
    }
}
