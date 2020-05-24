using System;
using System.Text;
using Model;
using Dao;
using System.Collections.Generic;

namespace Logic
{
    public class Reservation_Service
    {
        Reservation_DAO reservation_DAO = new Reservation_DAO();

        //Get a list of all the reservations from the DAO
        public List<Reservation> GetAllReservations()
        {
            return reservation_DAO.GetAll();
        }

        //Add a new reservation
        public void AddReservation(Reservation reservation)
        {
            reservation_DAO.Add(reservation);
        }

        //Remove a reservation
        public void RemoveReservation(Reservation reservation)
        {
            reservation_DAO.Remove(reservation);
        }

        //Modify the properties of the reservation
        public void ModifyReservation(Reservation reservation)
        {
            reservation_DAO.Modify(reservation);
        }
    }
}
