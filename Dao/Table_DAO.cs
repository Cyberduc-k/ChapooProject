using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Table_DAO : Base
    {
        public List<Table> GetAll()
        {
            // @TODO
            string query = "";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, parameters));
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dataRow in dataTable.Rows)
                tables.Add(ReadTable(dataRow));

            return tables;
        }

        private Table ReadTable(DataRow dataRow)
        {
            // @TODO
            return null;
        }
    }
}
