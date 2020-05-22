using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Employee_DAO : Base
    {
        // Get a list of all employees
        public List<Employee> GetAll()
        {
            // @TODO
            string query = "";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Add a new employee to the database
        public void Add(Employee employee)
        {
            // @TODO
        }

        // Remove an employee from the database
        public void Remove(Employee employee)
        {
            // @TODO
        }

        // Modify the properties of an employee in the database
        public void Modify(Employee employee)
        {
            // @TODO
        }

        // Convert the raw database data into a list of Employee objects
        private List<Employee> ReadAll(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dataRow in dataTable.Rows)
                employees.Add(Read(dataRow));

            return employees;
        }

        // Convert the raw database data into an Employee object
        private Employee Read(DataRow dataRow)
        {
            // @TODO
            return null;
        }
    }
}
