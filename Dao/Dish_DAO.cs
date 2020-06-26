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

        // Get the last dish id
        public int GetLastId()
        {
            string query = "SELECT IDENT_CURRENT('Dishes') as nextId";
            SqlParameter[] parameters = new SqlParameter[0];

            DataTable table = ExecuteSelectQuery(query, parameters);
            DataRow row = table.Rows[0];

            return int.Parse(row["nextId"].ToString());
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
                "SELECT D.[id], D.[name], D.[description], D.[ingredients], D.[price], D.[stock], D.[category], OD.[finished], OD.[comment] " +
                "FROM [dbo].[Dishes] AS D " +
                "JOIN [dbo].[Order_has_dish] AS OD ON OD.[dishId] = D.[id] " +
                "WHERE OD.[orderId] = @orderId";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@orderId", orderId),
            };

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        //@TODO implement
        public List<Dish> OrderByStock()
        {
            return null;
        }

        // Add a new dish to the database
        public void Add(Dish dish, MenuType menu)
        {
            string query = "INSERT INTO [dbo].[Dishes] ([name], [description], [ingredients], [price], [stock], [category]) VALUES (@name, @description, @ingredients, @price, @stock, @category)";
            SqlParameter[] parameters = new SqlParameter[6]
            {
                new SqlParameter("@name", dish.Name),
                new SqlParameter("@description", dish.Description),
                new SqlParameter("@ingredients", dish.Ingredients),
                new SqlParameter("@price", dish.Price),
                new SqlParameter("@stock", dish.Stock),
                new SqlParameter("@category", (int)dish.Category)
            };

            ExecuteEditQuery(query, parameters);

            query = "INSERT INTO [dbo].[Menu_has_dish] ([menuId], [dishId]) VALUES (@menuId, @dishId)";
            parameters = new SqlParameter[2]
            {
                new SqlParameter("@menuId", (int)menu + 1),
                new SqlParameter("@dishId", GetLastId()),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Remove a dish from the database
        public void Remove(int id)
        {
            string query = "DELETE FROM [dbo].[Dishes] WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@id", id),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Modify the properties of a dish in the database
        public void Modify(Dish dish)
        {
            string query = "UPDATE [dbo].[Dishes] SET " +
                "[name] = @name, [description] = @description, [ingredients] = @ingredients, [price] = @price, [stock] = @stock, [category] = @category " +
                "WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[7]
            {
                new SqlParameter("@name", dish.Name),
                new SqlParameter("@description", dish.Description),
                new SqlParameter("@ingredients", dish.Ingredients),
                new SqlParameter("@price", dish.Price),
                new SqlParameter("@stock", dish.Stock),
                new SqlParameter("@category", dish.Category),
                new SqlParameter("@id", dish.Id),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Modify the stock of a dish in the database
        public void ModifyStock(int id, int stock)
        {
            string query = "UPDATE [dbo].[Dishes] SET [stock] = @stock WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[2]
            {
                new SqlParameter("@stock", stock),
                new SqlParameter("@id", id),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Empty the stock of a dish in the database
        public void EmptyStock(int id)
        {
            string query = "UPDATE [dbo].[Dishes] SET [stock] = 0 WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@id", id)
            };

            ExecuteEditQuery(query, parameters);
        }

        public void ModifyFinished(Order order, Dish dish, bool finished)
        {
            string query =
                "UPDATE [dbo].[Order_has_dish] " +
                "SET [finished] = @finished " +
                "WHERE [orderId] = @orderId AND [dishId] = @dishId";
            SqlParameter[] parameters = new SqlParameter[3]
            {
                new SqlParameter("@finished", finished),
                new SqlParameter("@orderId", order.Id),
                new SqlParameter("@dishId", dish.Id),
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
            
            if (dataRow.Table.Columns.Contains("finished") && !dataRow.IsNull("finished"))
            {
                bool finished = (bool)dataRow["finished"];
                string comment = dataRow.IsNull("comment") ? "" : (string)dataRow["comment"];

                return new Dish(id, name, description, ingredients, price, stock, category, finished, comment);
            }
            else
                return new Dish(id, name, description, ingredients, price, stock, category);
        }
    }
}
