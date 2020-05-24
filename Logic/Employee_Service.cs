using System;
using System.Text;
using Model;
using Dao;
using System.Collections.Generic;

namespace Logic
{
    public class Employee_Service
    {
        Employee_DAO employee_DAO = new Employee_DAO();

        // Get a list of all the employees from the DAO
        public List<Employee> GetAllEmployees() 
        {
            return employee_DAO.GetAll();
        }

        // Get a single Employee with an id and password
        public Employee GetWithPassword(int id, string password)
        {
            return employee_DAO.GetWithPassword(id, password);
        }

        // Add a new Employee
        public void AddEmployee(Employee employee)
        {
            employee_DAO.Add(employee);
        }

        // Remove an employee
        public void DeleteEmployee(Employee employee)
        {
            employee_DAO.Remove(employee);
        }

        public void DeleteEmployee(int id)
        {
            employee_DAO.Remove(id);
        }

        // Modify the properties of the employee
        public void ModifyEmployee(Employee employee)
        {
            employee_DAO.Modify(employee);
        }
    }
}
