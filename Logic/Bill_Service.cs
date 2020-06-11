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
            return bill_DAO.GetAll();
        }

        // Get bill by tableId
        public Bill GetBillByTableId(int tableId)
        {
            return bill_DAO.GetBillByTableId(tableId);
        }

        //Add a new bill
        public void AddBill(Bill bill)
        {
            bill_DAO.Add(bill);
        }

        //Remove a bill
        public void RemoveBill(Bill bill)
        {
            bill_DAO.Remove(bill);
        }

        //Modify the properties of a bill
        public void ModifyBill(Bill bill)
        {
            bill_DAO.Modify(bill);
        }
    }
}