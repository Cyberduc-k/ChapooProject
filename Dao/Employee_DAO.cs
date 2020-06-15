using System;
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
            string query = "SELECT [id], [dateOfBirth], [dateOfEmployment], [firstname], [lastname], [password], [employeeType], [gender] FROM [dbo].[Employees]";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        //Get an employee with a specific id
        public Employee GetWithId(int id)
        {
            string query = "SELECT [id], [dateOfBirth], [dateOfEmployment], [firstname], [lastname], [password], [employeeType], [gender] FROM [dbo].[Employees] WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@id", id),
            };

            return ReadAll(ExecuteSelectQuery(query, parameters))[0];
        }

        //Get an employee with a specific password
        public Employee GetWithPassword(int id, string password)
        {
            string query = "SELECT [id], [dateOfBirth], [dateOfEmployment], [firstname], [lastname], [password], [employeeType], [gender] FROM [dbo].[Employees] WHERE [id] = @id AND [password] = @password";
            SqlParameter[] parameters = new SqlParameter[2]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@password", password),
            };

            DataTable results = ExecuteSelectQuery(query, parameters);

            if (results == null || results.Rows.Count == 0)
                return null;
            else
                return Read(results.Rows[0]);
        }

        // Add a new employee to the database
        public void Add(Employee employee)
        {
            string query = "INSERT INTO [dbo].[Employees] ([dateOfBirth], [dateOfEmployment], [firstname], [lastname], [password], [employeeType], [gender]) VALUES (@dateOfBirth, @dateOfEmployment, @firstname, @lastname, @password, @employeeType, @gender)";
            SqlParameter[] parameters = new SqlParameter[7]
            {
                new SqlParameter("@dateOfBirth", employee.BirthDate),
                new SqlParameter("@dateOfEmployment", employee.DateEmployment),
                new SqlParameter("@firstname", employee.FirstName),
                new SqlParameter("@lastname", employee.LastName),
                new SqlParameter("@password", employee.Password),
                new SqlParameter("@employeeType", employee.EmployeeType),
                new SqlParameter("@gender", employee.Gender),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Remove an employee from the database
        public void Remove(Employee employee)
        {
            string query = "DELETE FROM [dbo].[Employees] WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@id", employee.Id),
            };

            ExecuteEditQuery(query, parameters);
        }

        //Remove employee by id
        public void Remove(int id)
        {
            string query = "DELETE FROM [dbo].[Employees] WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@id", id),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Modify the properties of an employee in the database
        public void Modify(Employee employee)
        {
            string query = "UPDATE [dbo].[Employees] SET [dateOfBirth] = @dateOfBirth, [dateOfEmployment] = @dateOfEmployment, [firstname] = @firstname, [lastname] = @lastname, [password] = @password, [employeeType] = @employeeType, [gender] = @gender WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[8]
            {
                new SqlParameter("@id", employee.Id),
                new SqlParameter("@dateOfBirth", employee.BirthDate),
                new SqlParameter("@dateOfEmployment", employee.DateEmployment),
                new SqlParameter("@firstname", employee.FirstName),
                new SqlParameter("@lastname", employee.LastName),
                new SqlParameter("@password", employee.Password),
                new SqlParameter("@employeeType", employee.EmployeeType),
                new SqlParameter("@gender", employee.Gender),
            };

            ExecuteEditQuery(query, parameters);
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
            int id = (int)dataRow["id"];
            DateTime dateOfBirth = (DateTime)dataRow["dateOfBirth"];
            DateTime dateEmployment = (DateTime)dataRow["dateOfEmployment"];
            string firstname = (string)dataRow["firstname"];
            string lastname = (string)dataRow["lastname"];
            string password = (string)dataRow["password"];
            EmployeeType employeeType = (EmployeeType)(byte)dataRow["employeeType"];
            Gender gender = (Gender)(byte)dataRow["gender"];

            return new Employee(id, firstname, lastname, dateOfBirth, dateEmployment, gender, password, employeeType);
        }
    }
}
