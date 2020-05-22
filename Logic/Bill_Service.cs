using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Dao;

namespace Logic
{
    public class Bill_Service
    {
        Bill_DAO bill_DAO = new Bill_DAO();

        //Get a list of all the bills from the DAO
        public List<Bill> GetAllBills()
        {
            // @TODO
        }

        //Add a new bill
        public void AddBill(Bill bill)
        {
            // @TODO
        }

        //Remove a bill
        public void RemoveBill(Bill bill)
        {
            // @TODO
        }

        //Modify the properties of a bill
        public void ModifyBill(Bill bill)
        {
            // @TODO
        }
    }
}