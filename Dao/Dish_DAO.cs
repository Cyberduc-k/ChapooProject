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
            string query = "SELECT [id], [name], [description], [ingredients], [price], [stock], [category] FROM [dbo].[Dishes]";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        public List<Dish> GetAllDinner()
        {
            //1 is the diner card
            string query = "SELECT Dishes.id, [name], [description], [ingredients], [price], [stock], [category] FROM Dishes JOIN Menu_has_dish ON Dishes.id=Menu_has_dish.dishId JOIN Menus ON Menu_has_dish.menuId=Menus.id WHERE menuType = 1";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        public List<Dish> GetAllLunch()
        {
            //0 is the lunch card
            string query = "SELECT Dishes.id, [name], [description], [ingredients], [price], [stock], [category] FROM Dishes JOIN Menu_has_dish ON Dishes.id=Menu_has_dish.dishId JOIN Menus ON Menu_has_dish.menuId=Menus.id WHERE menuType = 0";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        public List<Dish> GetAllForOrder(int orderId)
        {
            string query =
                "SELECT D.[id], D.[name], D.[description], D.[ingredients], D.[price], D.[stock], D.[category] " +
                "FROM[dbo].[Dishes] AS D " +
                "JOIN[dbo].[Order_has_dish] AS OD ON OD.[dishId] = D.[id] " +
                "WHERE OD.[orderId] = @orderId";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@orderId", orderId),
            };

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
            string description = dataRow["description"].ToString();
            string ingredients = (string)dataRow["ingredients"];
            double price = (double)dataRow["price"];
            int stock = (int)dataRow["stock"];
            DishCategory category = (DishCategory)int.Parse(dataRow["category"].ToString());

            return new Dish(id, name, description, ingredients, price, stock, category);
        }
    }
}
