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
            string query = "SELECT [id], [date], [tableId], [employeeId] FROM [dbo].[Bills] WHERE [date] BETWEEN @from AND @to";
            SqlParameter[] parameters = new SqlParameter[2]
            {
                new SqlParameter("@from", from.Date.ToString()),
                new SqlParameter("@to", to.Date.ToString()),
            };

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

            foreach (Order order in bill.Orders)
            {
                Order_DAO order_dao = new Order_DAO();

                order_dao.Add(order);
            }

            ExecuteEditQuery(query, parameters);

            AddBillHasOrder(bill);
        }

        private int GetLastBillId()
        {
            string query = "SELECT [id] FROM [dbo].[Bills] ORDER BY [id] DESC";
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable result = ExecuteSelectQuery(query, parameters);
            DataRow row = result.Rows[0];

            return (int)row["id"];
        }

        private void AddBillHasOrder(Bill bill)
        {
            int billId = GetLastBillId();

            foreach (Order order in bill.Orders)
            {
                string query = "INSERT INTO [dbo].[Bill_hasorder] ([billId], [orderId]) VALUES (@billId, @orderId)";
                SqlParameter[] parameters = new SqlParameter[2]
                {
                    new SqlParameter("@billId", billId),
                    new SqlParameter("@orderId", order.Id),
                };

                ExecuteEditQuery(query, parameters);
            }
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