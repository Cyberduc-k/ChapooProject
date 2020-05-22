using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Reservation_DAO
    {
        //Get all reservations
        public List<Reservation> GetAll()
        {
            // @TODO
            return null;
        }

        //Change values of a reservation
        public void ModifyReservation(Reservation reservation)
        {
            // @TODO
        }

        //Add a new reservation
        public void AddReservation(Reservation reservation)
        {
            // @TODO
        }

        public void RemoveReservation(Reservation reservation)
        {
            // @TODO
        }

        private List<Reservation> ReadReservations(DataTable dataTable)
        {
            List<Reservation> reservations = new List<Reservation>();

            foreach (DataRow dataRow in dataTable.Rows)
                reservations.Add(ReadReservation(dataRow));

            return reservations;
        }

        private Reservation ReadReservation(DataRow dataRow)
        {
            // @TODO
            return null;
        }
    }
}
