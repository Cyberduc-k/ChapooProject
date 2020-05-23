using System;
using System.Text;
using Model;
using Dao;
using System.Collections.Generic;

namespace Logic
{
    public class Table_Service
    {
        Table_DAO table_DAO = new Table_DAO();

        //Get a list of all the tables from the DAO
        public List<Table> GetAllTables()
        {
            return null;
        }

        //Add a new table
        public void AddTable(Table table)
        {

        }

        //Remove a table
        public void DeleteTable(Table table)
        {

        }

        //Modify the properties of the table
        public void ModifyTable(Table table)
        {

        }
    }
}
