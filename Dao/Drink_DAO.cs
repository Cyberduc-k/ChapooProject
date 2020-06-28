using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Drink_DAO : Base
    {      
        // Get a list of all the drinks
        public List<Drink> GetAll()
        {
            string query = "SELECT [id], [name], [alcoholic], [price], [stock] FROM [dbo].[Drinks]";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }
        // Get the last drink id
        public int GetLastId()
        {
            string query = "SELECT IDENT_CURRENT('Drinks') as nextId";
            SqlParameter[] parameters = new SqlParameter[0];

            DataTable table = ExecuteSelectQuery(query, parameters);
            DataRow row = table.Rows[0];

            return int.Parse(row["nextId"].ToString());
        }

        // Get a list of all drinks for the specified order
        public List<Drink> GetAllForOrder(int orderId)
        {
            string query =
                "SELECT D.[id], D.[name], D.[alcoholic], D.[price], D.[stock], OD.[finished], OD.[comment], OD.[aantal] " +
                "FROM [dbo].[Drinks] AS D " +
                "JOIN [dbo].[Order_has_drink] AS OD ON OD.[drinkId] = D.[id] " +
                "WHERE OD.[orderId] = @orderId";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@orderId", orderId),
            };

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        //@TODO implement
        public List<Drink> OrderByStock()
        {
            return null;
        }

        // Add a new drink to the database
        public void Add(Drink drink)
        {
            string query = "INSERT INTO [dbo].[Drinks] ([name], [alcoholic], [price], [stock]) VALUES (@name, @alcoholic, @price, @stock)";
            SqlParameter[] parameters = new SqlParameter[4]
            {
                new SqlParameter("@name", drink.Name),
                new SqlParameter("@alcoholic", drink.Alcoholic),
                new SqlParameter("@price", drink.Price),
                new SqlParameter("@stock", drink.Stock),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Remove a drink from the database
        public void Remove(int id)
        {
            string query = "DELETE FROM [dbo].[Drinks] WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@id", id),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Modify the properties of a drink in the database
        public void Modify(Drink drink)
        {
            string query = "UPDATE [dbo].[Drinks] SET [name] = @name, [price] = @price, [stock] = @stock, [alcoholic] = @alcoholic WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[5]
            {
                new SqlParameter("@name", drink.Name),
                new SqlParameter("@alcoholic", drink.Alcoholic),
                new SqlParameter("@price", drink.Price),
                new SqlParameter("@stock", drink.Stock),
                new SqlParameter("@id", drink.Id),
            };
            
            ExecuteEditQuery(query, parameters);
        }

        // Modify the stock of a drink in the database
        public void ModifyStock(int id, int stock)
        {
            string query = "UPDATE [dbo].[Drinks] SET [stock] = @stock WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[2]
            {
                new SqlParameter("@stock", stock),
                new SqlParameter("@id", id),
            };
            
            ExecuteEditQuery(query, parameters);
        }

        // Empty the stock of a drink in the database
        public void EmptyStock(int id)
        {
            string query = "UPDATE [dbo].[Drinks] SET [stock] = 0 WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@id", id)
            };

            ExecuteEditQuery(query, parameters);
        }

        public void ModifyFinished(Order order, Drink drink, bool finished)
        {
            string query =
                "UPDATE [dbo].[Order_has_drink] " +
                "SET [finished] = @finished " +
                "WHERE [orderId] = @orderId AND [drinkId] = @drinkId";
            SqlParameter[] parameters = new SqlParameter[3]
            {
                new SqlParameter("@finished", finished),
                new SqlParameter("@orderId", order.Id),
                new SqlParameter("@drinkId", drink.Id),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Convert the raw database data into a list of Drink objects
        private List<Drink> ReadAll(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dataRow in dataTable.Rows)
                drinks.Add(Read(dataRow));

            return drinks;
        }

        // Convert the raw database data into a Drink object
        private Drink Read(DataRow dataRow)
        {
            int id = (int)dataRow["Id"];
            string name = (string)dataRow["name"];
            bool alcoholic = (bool)dataRow["alcoholic"];
            double price = (double)dataRow["price"];
            int stock = (int)dataRow["stock"];

            if (dataRow.Table.Columns.Contains("finished") && !dataRow.IsNull("finished"))
            {
                bool finished = (bool)dataRow["finished"];
                string comment = dataRow.IsNull("comment") ? "" : (string)dataRow["comment"];
                int aantal = (int)dataRow["aantal"];

                return new Drink(id, name, alcoholic, price, stock, finished, comment, aantal);
            }
            else
                return new Drink(id, name, alcoholic, price, stock);
        }
    }
}
