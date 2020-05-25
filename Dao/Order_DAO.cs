﻿using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using Model;

namespace Dao
{
    public class Order_DAO : Base
    {
        // Get a list of all the orders
        public List<Order> GetAll()
        {
            string query = "SELECT [id], [comment], [orderState], [timeOrdering], [timeFinished], [tableId], [employeeId] FROM [dbo].[Orders]";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Add a new order to the database
        public void Add(Order order)
        {
            string query = "INSERT INTO [dbo].[Orders] " +
                "([comment],[orderState],[timeOrdering], [timeFinished], [tableId], [employeeId]) VALUES (@comment, @orderState, @timeOrdering, @timeFinished, @tableId, @employeeId)";
            SqlParameter[] parameters = new SqlParameter[6]
            {
                new SqlParameter("@comment", order.Comment),
                new SqlParameter("@orderState", (int)order.State),
                new SqlParameter("@timeOrdering", order.TimeOrdering.ToString()),
                new SqlParameter("@timeFinished", order.TimeFinished.ToString()),
                new SqlParameter("@tableId", order.TableId),
                new SqlParameter("@employeeId", order.EmployeeId),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Remove an order from the database
        public void Remove(Order order)
        {
            string query = "DELETE FROM [dbo].[Orders] WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@id", order.Id),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Modify the properties of an order in the database
        public void Modify(Order order)
        {
            string query = "UPDATE [dbo].[Orders] SET " +
                "[comment] = @comment, [orderState] = @orderState, [timeOrdering] = @timeOrdering, [timeFinished] = @timeFinished, [tableId] = @tableId, [employeeId] = @employeeId" +
                "WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[7]
            {
                new SqlParameter("@comment", order.Comment),
                new SqlParameter("@orderState", (int)order.State),
                new SqlParameter("@timeOrdering", order.TimeOrdering.ToString()),
                new SqlParameter("@timeFinished", order.TimeFinished.ToString()),
                new SqlParameter("@tableId", order.TableId),
                new SqlParameter("@employeeId", order.EmployeeId),
                new SqlParameter("@id", order.Id)
            };

            ExecuteEditQuery(query, parameters);
        }

        // Convert the raw database data into a list of Order objects
        private List<Order> ReadAll(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dataRow in dataTable.Rows)
                orders.Add(Read(dataRow));

            return orders;
        }

        // Convert the raw database data into an Order object
        private Order Read(DataRow dataRow)
        {
            int id = (int)dataRow["id"];
            List<Dish> dishes = new List<Dish>();
            List<Drink> drinks = new List<Drink>();
            int employeeId = int.Parse(dataRow["employeeId"].ToString());
            int tableId = int.Parse(dataRow["tableId"].ToString());
            OrderState state = (OrderState)int.Parse(dataRow["orderState"].ToString());
            string comment = (string)dataRow["comment"];

            DateTime timeOrdering;
            DateTime.TryParse(dataRow["timeOrdering"].ToString(), out timeOrdering);
            DateTime timeFinished;
            DateTime.TryParse(dataRow["timeFinished"].ToString(), out timeFinished);

            return new Order(id, timeOrdering, timeFinished, dishes, drinks, employeeId, tableId, state, comment);
        }
    }
}
