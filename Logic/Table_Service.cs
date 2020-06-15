using Model;
using Dao;
using System.Collections.Generic;

namespace Logic
{
    public class Table_Service
    {
        Table_DAO table_DAO = new Table_DAO();

        // Get a list of all the tables from the DAO
        public List<Table> GetAllTables()
        {
            return table_DAO.GetAll();
        }

        //Get the corresponding table with an id
        public Table GetWithId(int id)
        {
            return table_DAO.GetWithId(id);
        }

        // Add a new table
        public void AddTable(Table table)
        {
            table_DAO.Add(table);
        }

        // Remove a table
        public void DeleteTable(Table table)
        {
            table_DAO.Remove(table);
        }

        // Modify the properties of the table
        public void ModifyTable(Table table)
        {
            table_DAO.Modify(table);
        }
    }
}
