using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Order_DAO : Base
    {
        public List<Order> GetAll()
        {
            // @TODO
            string query = "";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadOrders(ExecuteSelectQuery(query, parameters));
        }

        private List<Order> ReadOrders(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dataRow in dataTable.Rows)
                orders.Add(ReadOrder(dataRow));

            return orders;
        }

        private Order ReadOrder(DataRow dataRow)
        {
            // @TODO
            return null;
        }
    }
}
