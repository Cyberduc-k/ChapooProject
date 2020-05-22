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
        public List<Menu> GetAllMenus()
        {
            return null;
        }

        //Add a new reservation
        public void AddReservation(Reservation reservation)
        {

        }

        //Remove a reservation
        public void DeleteReservation(Reservation reservation)
        {

        }

        //Modify the properties of the reservation
        public void ModifyReservation(Reservation reservation)
        {

        }
    }
}
