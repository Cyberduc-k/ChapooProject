using System.Collections.Generic;
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
            string query =
                "SELECT [id], [orderState], [timeOrdering], [timeFinished], [tableId], [employeeId] " +
                "FROM [dbo].[Orders] " +
                "ORDER BY [timeOrdering], [timeFinished] DESC";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        public List<Order> GetAllForBill(int billId)
        {
            string query =
                "SELECT [D].[id], [D].[orderState], [D].[timeOrdering], [D].[timeFinished], [D].[tableId], [D].[employeeId] " +
                "FROM [dbo].[Orders] AS D " +
                "JOIN [dbo].[Bill_has_Order] AS B ON B.[orderId] = D.[id] " +
                "WHERE B.[billId] = @billId";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@billId", billId),
            };

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Add a new order to the database
        public void Add(Order order)
        {
            string query = "INSERT INTO [dbo].[Orders] " +
                "([orderState], [timeOrdering], [timeFinished], [tableId], [employeeId]) VALUES (@orderState, @timeOrdering, @timeFinished, @tableId, @employeeId)";
            SqlParameter[] parameters = new SqlParameter[5]
            {
                new SqlParameter("@orderState", order.State),
                new SqlParameter("@timeOrdering", order.TimeOrdering.TimeOfDay),
                new SqlParameter("@timeFinished", order.TimeFinished.TimeOfDay),
                new SqlParameter("@tableId", order.TableId),
                new SqlParameter("@employeeId", order.EmployeeId),
            };

            ExecuteEditQuery(query, parameters);
            order.Id = GetLastOrderId();

            foreach (Dish dish in order.Dishes)
            {
                string query2 = "INSERT INTO [dbo].[Order_has_dish] ([orderId], [dishId], [finished], [comment], [aantal]) VALUES (@orderId, @dishId, @finished, @comment, @aantal)";
                SqlParameter[] parameters2 = new SqlParameter[5]
                {
                    new SqlParameter("@orderId", order.Id),
                    new SqlParameter("@dishId", dish.Id),
                    new SqlParameter("@finished", dish.Finished),
                    new SqlParameter("@comment", dish.Comment),
                    new SqlParameter("@aantal", dish.Aantal),
                };

                ExecuteEditQuery(query2, parameters2);
            }

            foreach (Drink drink in order.Drinks)
            {
                string query2 = "INSERT INTO [dbo].[Order_has_drink] ([orderId], [drinkId], [finished], [comment], [aantal]) VALUES (@orderId, @drinkID, @finished, @comment, @aantal)";
                SqlParameter[] parameters2 = new SqlParameter[5]
                {
                    new SqlParameter("@orderId", order.Id),
                    new SqlParameter("@drinkId", drink.Id),
                    new SqlParameter("@finished", drink.Finished),
                    new SqlParameter("@comment", drink.Comment),
                    new SqlParameter("@aantal", drink.Aantal),
                };

                ExecuteEditQuery(query2, parameters2);
            }
        }

        public void AddOrderWhereBillIdIs(Order order, int billId)
        {
            Add(order);

            string query = "INSERT INTO [dbo].[Bill_has_order] ([billId], [orderId]) VALUES (@billId, @orderId)";
            SqlParameter[] parameters = new SqlParameter[2]
            {
                new SqlParameter("@billId", billId),
                new SqlParameter("@orderId", order.Id),
            };

            ExecuteEditQuery(query, parameters);
        }

        private int GetLastOrderId()
        {
            string query = "SELECT [id] FROM [dbo].[Orders] ORDER BY [id] DESC";
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable result = ExecuteSelectQuery(query, parameters);
            DataRow row = result.Rows[0];

            return (int)row["id"];
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
                "[orderState] = @orderState, [timeOrdering] = @timeOrdering, [timeFinished] = @timeFinished, [tableId] = @tableId, [employeeId] = @employeeId " +
                "WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[6]
            {
                new SqlParameter("@orderState", order.State),
                new SqlParameter("@timeOrdering", order.TimeOrdering.TimeOfDay),
                new SqlParameter("@timeFinished", order.TimeFinished.TimeOfDay),
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
            List<Dish> dishes = new Dish_DAO().GetAllForOrder(id);
            List<Drink> drinks = new Drink_DAO().GetAllForOrder(id);
            int employeeId = int.Parse(dataRow["employeeId"].ToString());
            int tableId = int.Parse(dataRow["tableId"].ToString());
            OrderState state = (OrderState)int.Parse(dataRow["orderState"].ToString());

            DateTime timeOrdering;
            DateTime.TryParse(dataRow["timeOrdering"].ToString(), out timeOrdering);
            DateTime timeFinished;
            DateTime.TryParse(dataRow["timeFinished"].ToString(), out timeFinished);

            return new Order(id, timeOrdering, timeFinished, dishes, drinks, employeeId, tableId, state);
        }
    }
}
