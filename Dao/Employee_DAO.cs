using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Employee_DAO : Base
    {
        public List<Employee> GetAll()
        {
            // @TODO
            string query = "";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadEmployees(ExecuteSelectQuery(query, parameters));
        }

        private List<Employee> ReadEmployees(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dataRow in dataTable.Rows)
                employees.Add(ReadEmployee(dataRow));

            return employees;
        }

        private Employee ReadEmployee(DataRow dataRow)
        {
            // @TODO
            return null;
        }
    }
}
