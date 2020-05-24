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
            string query = "";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Add a new order to the database
        public void Add(Order order)
        {
            // @TODO
        }

        // Remove an order from the database
        public void Remove(Order order)
        {
            // @TODO
        }

        // Modify the properties of an order in the database
        public void Modify(Order order)
        {
            // @TODO
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
            // @TODO
            return null;
        }
    }
}
