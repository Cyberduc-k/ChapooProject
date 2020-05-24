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
            string query = "SELECT [id], [name], [alcoholic], [price], [stock] FROM [dbo].[Drink]";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Add a new drink to the database
        public void Add(Drink drink)
        {
            string query = "INSERT INTO [dbo].[Drink] ([name], [alcoholic], [price], [stock]) VALUES (@name, @alcoholic, @price, @stock)";
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
        public void Remove(Drink drink)
        {
            string query = "DELETE FROM [dbo].[Drink] WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@id", drink.Id),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Modify the properties of a drink in the database
        public void Modify(Drink drink)
        {
            string query = "UPDATE [dbo].[Drink] SET [name] = @name, [price] = @price, [stock] = @stock, [alcoholic] = @alcoholic WHERE [id] = @id";
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
            
            return new Drink(id, name, alcoholic, price, stock);
        }
    }
}
