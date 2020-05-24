﻿using System;
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
            string query = "SELECT [id], [dateOfBirth], [dateEmployment], [firstname], [lastname], [password], [employeeType], [gender] FROM [dbo].[Employee]";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        public Employee GetWithPassword(int id, string password)
        {
            string query = "SELECT [id], [dateOfBirth], [dateEmployment], [firstname], [lastname], [password], [employeeType], [gender] FROM [dbo].[Employee] WHERE [id] = @id AND [password] = @password";
            SqlParameter[] parameters = new SqlParameter[2]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@password", id),
            };

            DataTable results = ExecuteSelectQuery(query, parameters);

            if (results.Rows.Count == 0)
                return null;
            else
                return Read(results.Rows[0]);
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
            int id = (int)dataRow["id"];
            DateTime dateOfBirth = (DateTime)dataRow["dateOfBirth"];
            DateTime dateEmployment = (DateTime)dataRow["dateEmployment"];
            string firstname = (string)dataRow["firstname"];
            string lastname = (string)dataRow["lastname"];
            string password = (string)dataRow["password"];
            EmployeeType employeeType = (EmployeeType)dataRow["employeeType"];
            Gender gender = (Gender)dataRow["gender"];

            return new Employee(id, firstname, lastname, dateOfBirth, dateEmployment, gender, password, employeeType);
        }
    }
}
