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
            string query = "SELECT [id], [date], [timeOrdering], [timeFinished], [dishes], [drinks], [employee], [table], [state], [comment] FROM [dbo].[Orders]";

            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Add a new order to the database
        public void Add(Order order)
        {
            string query = "INSERT INTO [dbo].[Orders] " +
                "([date], [timeOrdering], [timeFinished], [dishes], [drinks], [employee], [table], [state]) " +
                "VALUES " +
                "(@date, @timeOrdering, @timeFinished, @dishes, @drinks, @employee, @table, @state)";
            SqlParameter[] parameters = new SqlParameter[7]
            {
                new SqlParameter("@timeOrdering", order.TimeOrdering),
                new SqlParameter("@timeFinished", order.TimeFinished),
                new SqlParameter("@dishes", order.Dishes),
                new SqlParameter("@drinks", order.Drinks),
                new SqlParameter("@employee", order.Employee),
                new SqlParameter("@table", order.Table),
                new SqlParameter("@state", order.State),
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
                "[date] = @date, [timeOrdering] = @timeOrdering, [timeFinished] = @timeFinished, [dishes] = @dishes, [drinks] = @drinks, [employee] = @employee, [table] = @table, [state] = @state" +
                "WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[8]
            {
                new SqlParameter("@timeOrdering", order.TimeOrdering),
                new SqlParameter("@timeFinished", order.TimeFinished),
                new SqlParameter("@dishes", order.Dishes),
                new SqlParameter("@drinks", order.Drinks),
                new SqlParameter("@employee", order.Employee),
                new SqlParameter("@table", order.Table),
                new SqlParameter("@state", order.State),
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
            DateTime timeOrdering = (DateTime)dataRow["timeOrdering"];
            DateTime timeFinished = (DateTime)dataRow["timeFinished"];
            List<Dish> dishes = (List<Dish>)dataRow["dishes"];
            List<Drink> drinks = (List<Drink>)dataRow["drinks"];
            Employee employee = (Employee)dataRow["employeeId"];
            Table table = (Table)dataRow["tableId"];
            OrderState state = (OrderState)dataRow["state"];
            string comment = (string)dataRow["comment"];

            return new Order(id, timeOrdering, timeFinished, dishes, drinks, employee, table, state, comment);
        }
    }
}
