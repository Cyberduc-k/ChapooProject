using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Menu_DAO : Base
    {
        // Get a list of all the menus
        public List<Menu> GetAll()
        {
            // @TODO
            string query = "SELECT [id], [menuType] FROM [dbo].[Menus]";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Add a new menu to the database
        public void Add(Menu menu)
        {
            string query = "INSERT INTO [dbo].[Menus] ([menuType]) VALUES (@menuType)";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@menuType", menu.MenuType),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Remove a menu from the database
        public void Remove(Menu menu)
        {
            string query = "DELETE FROM [dbo].[Menus] WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@id", menu.Id),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Modify the properties of a menu in the database
        public void Modify(Menu menu)
        {
            string query = "UPDATE [dbo].[Menus] SET " +
                "[menuType] = @menuType" +
                "WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[2]
            {
                new SqlParameter("@menuType", menu.MenuType),
                new SqlParameter("@id", menu.Id),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Convert the raw database data into a list of Menu objects
        private List<Menu> ReadAll(DataTable dataTable)
        {
            List<Menu> menus = new List<Menu>();

            foreach (DataRow dataRow in dataTable.Rows)
                menus.Add(Read(dataRow));

            return menus;
        }

        // Convert the raw database data into a Menu object
        private Menu Read(DataRow dataRow)
        {
            int id = (int)dataRow["id"];
            MenuType menuType = (MenuType)dataRow["menuType"];

            return new Menu(id, menuType);
        }
    }
}
