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
            return order_DAO.GetAll();
        }

        //Add a new order
        public void AddOrder(Order order)
        {
            order_DAO.Add(order);
        }

        //Remove a order
        public void RemoveOrder(Order order)
        {
            order_DAO.Remove(order);
        }

        //Modify the properties of a order
        public void ModifyOrder(Order order)
        {
            order_DAO.Modify(order);
        }

        public void AddOrderWhereBillIdIs(Order order, int billId)
        {
            order_DAO.AddOrderWhereBillIdIs(order, billId);
        }
    }
}