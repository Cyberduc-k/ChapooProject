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

        //Get a list of all the employees from the DAO
        public List<Employee> GetAllEmployees() 
        {
            return null;
        }

        //Add a new Employee
        public void AddEmployee(Employee employee)
        {

        }

        //Remove an employee
        public void DeleteEmployee(Employee employee)
        { 
            
        }

        //Modify the properties of the employee
        public void ModifyEmployee(Employee employee)
        {

        }
    }
}
