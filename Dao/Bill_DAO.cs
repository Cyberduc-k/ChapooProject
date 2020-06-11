using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using Model;

namespace Dao
{
    public class Bill_DAO : Base
    {
        // Get a list of all the billes
        public List<Bill> GetAll()
        {
            string query = "SELECT [id], [date], [tableId], [employeeId] FROM [dbo].[Bills]";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Get bill by tableId
        public Bill GetBillByTableId(int tableId)
        {
            string query = "SELECT [id], [date], [tableId], [employeeId] FROM [dbo].[Bills] WHERE [tableId] = @tableId";
            SqlParameter[] parameters = new SqlParameter[1] {
                new SqlParameter("@tableId", tableId),
            };

            return Read(ExecuteSelectQuery(query, parameters).Rows[0]);
        }

        //Get bills between 2 dates
        public List<Bill> GetAllBetweenDates(DateTime from, DateTime to)
        {
            string query = "SELECT [id], [date], [tableId], [employeeId] FROM [dbo].[Bills]";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Add a new bill to the database
        public void Add(Bill bill)
        {
            string query = "INSERT INTO [dbo].[Bills] ([date], [tableId], [employeeId]) VALUES (@date, @tableId, @employeeId)";
            SqlParameter[] parameters = new SqlParameter[3]
            {
                new SqlParameter("@date", bill.Date),
                new SqlParameter("@tableId", bill.Table),
                new SqlParameter("@employeeId", bill.Employee),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Remove a bill from the database
        public void Remove(Bill bill)
        {
            string query = "DELETE FROM [dbo].[Bills] WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@id", bill.Id),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Modify the properties of a bill in the database
        public void Modify(Bill bill)
        {
            string query = "UPDATE [dbo].[Bills] SET " +
                "[date] = @date, [tableId] = @table, [employeeId] = @employeeId " +
                "WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[4]
            {
                new SqlParameter("@date", bill.Date),
                new SqlParameter("@tableId", bill.Table),
                new SqlParameter("@employeeId", bill.Employee),
                new SqlParameter("@id", bill.Id),
            };

            ExecuteEditQuery(query, parameters);
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
            int id = (int)dataRow["Id"];
            DateTime date = (DateTime)dataRow["date"];
            Table table = new Table_DAO().GetWithId((int)dataRow["tableId"]);
            List<Order> orders = new Order_DAO().GetAllForBill(id);
            Employee employee = new Employee_DAO().GetWithId((int)dataRow["employeeId"]);
            
            return new Bill(id, date, table, orders, employee);
        }
    }
}