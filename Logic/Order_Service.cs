using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Dao;

namespace Logic
{
    public class Order_Service
    {
        Order_DAO order_DAO = new Order_DAO();

        //Get a list of all the orders from the DAO
        public List<Order> GetAllOrders()
        {
            // @TODO
            return null;
        }

        //Add a new order
        public void AddOrder(Order order)
        {
            // @TODO
        }

        //Remove a order
        public void RemoveOrder(Order order)
        {
            // @TODO
        }

        //Modify the properties of a order
        public void ModifyOrder(Order order)
        {
            // @TODO
        }
    }
}