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
            string query = "";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Add a new menu to the database
        public void Add(Menu menu)
        {
            // @TODO
        }

        // Remove a menu from the database
        public void Remove(Menu menu)
        {
            // @TODO
        }

        // Modify the properties of a menu in the database
        public void Modify(Menu menu)
        {
            // @TODO
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
            // @TODO
            return null;
        }
    }
}
