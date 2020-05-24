using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Dish_DAO : Base
    {
        // Get a list of all the dishes
        public List<Dish> GetAll()
        {
            string query = "SELECT [id], [name], [description], [ingredienst], [price], [stock] FROM [dbo].[Dishes]";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Add a new dish to the database
        public void Add(Dish dish)
        {
            string query = "INSERT INTO [dbo].[Dishes] ([name], [description], [ingredients], [price], [stock]) VALUES (@name, @description, @ingredients, @price, @stock)";
            SqlParameter[] parameters = new SqlParameter[5]
            {
                new SqlParameter("@name", dish.Name),
                new SqlParameter("@description", dish.Description),
                new SqlParameter("@ingredienst", dish.Ingredients),
                new SqlParameter("@price", dish.Price),
                new SqlParameter("@stock", dish.Stock),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Remove a dish from the database
        public void Remove(Dish dish)
        {
            string query = "DELETE FROM [dbo].[Dish] WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@id", dish.Id),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Modify the properties of a dish in the database
        public void Modify(Dish dish)
        {
            string query = "UPDATE [dbo].[Dishes] SET " +
                "[name] = @name, [description] = @description, [ingredients] = @ingredients, [price] = @price, [stock] = @stock " +
                "WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[5]
            {
                new SqlParameter("@name", dish.Name),
                new SqlParameter("@description", dish.Description),
                new SqlParameter("@price", dish.Price),
                new SqlParameter("@stock", dish.Stock),
                new SqlParameter("@id", dish.Id),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Convert the raw database data into a list of Dish objects
        private List<Dish> ReadAll(DataTable dataTable)
        {
            List<Dish> dishes = new List<Dish>();

            foreach (DataRow dataRow in dataTable.Rows)
                dishes.Add(Read(dataRow));

            return dishes;
        }

        // Convert the raw database data into an Dish object
        private Dish Read(DataRow dataRow)
        {
            int id = (int)dataRow["Id"];
            string name = (string)dataRow["name"];
            string description = (string)dataRow["description"];
            List<string> ingredients = (List<string>)dataRow["ingredients"];
            double price = (double)dataRow["price"];
            int stock = (int)dataRow["stock"];

            return new Dish(id, name, description, ingredients, price, stock);
        }
    }
}
