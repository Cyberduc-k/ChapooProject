using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Order_DAO : Base
    {
        // Get a list of all the orders
        public List<Order> GetAll()
        {
            // @TODO
            string query = "SELECT [id], [comment], [date], [timeOrdering], [timeFinished], [totalPrice], [tableId], [employeeId] FROM [dbo].[Orders]";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Add a new order to the database
        public void Add(Order order)
        {
            string query = "INSERT INTO [dbo].[Orders] ([comment], [date], [timeOrdering], [timeFinished], [totalPrice], [tableId], [employeeId]) VALUES (@comment, @date, @timeOrdering, @timeFinished, @totalPrice, @table, @employee)";
            SqlParameter[] parameters = new SqlParameter[7]
            {
                new SqlParameter("@comment", order.Comment),
                new SqlParameter("@date", order.Date),
                new SqlParameter("@timeOrdering", order.TimeOrdering),
                new SqlParameter("@timeFinished", order.TimeFinished),
                new SqlParameter("@totalPrice", order.TotalPrice),
                new SqlParameter("@table", order.Table),
                new SqlParameter("@employee", order.Employee),
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
            string query = "UPDATE [dbo].[Orders] " +
                "SET [comment] = @comment, [date] = @date, [timeOrdering] = @timeOrdering, [timeFinished] = @timeFinished, [totalPrice] = @totalPrice, [tableId] = @tableId, [employeeId] = @employeeId" +
                "WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[7]
            {
                new SqlParameter("@comment", order.Comment),
                new SqlParameter("@date", order.Date),
                new SqlParameter("@timeOrdering", order.TimeOrdering),
                new SqlParameter("@timeFinished", order.TimeFinished),
                new SqlParameter("@totalPrice", order.TotalPrice),
                new SqlParameter("@tableId", order.Table),
                new SqlParameter("@id", order.Id),
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
            //DateTime date = (DateTime)dataRow["date"];
            //DateTime timeOrdering = (DateTime)dataRow["timeOrdering"];
            //DateTime timeFinished = (DateTime)dataRow["timeFinished"];
            double totalPrice = (double)dataRow["totalPrice"];
            int tableId = (int)dataRow["tableId"];

            return new Order(id, date, timeOrdering, timeFinished, totalPrice, tableId);
        }
    }
}
