using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Table_DAO : Base
    {
        public List<Menu> GetAll()
        {
            // @TODO
            string query = "";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadMenus(ExecuteSelectQuery(query, parameters));
        }

        private List<Menu> ReadMenus(DataTable dataTable)
        {
            List<Menu> menus = new List<Menu>();

            foreach (DataRow dataRow in dataTable.Rows)
                menus.Add(ReadMenu(dataRow));

            return menus;
        }

        private Menu ReadMenu(DataRow dataRow)
        {
            // @TODO
            return null;
        }
    }
}
