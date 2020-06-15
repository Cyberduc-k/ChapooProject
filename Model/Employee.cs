using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime BirthDate { get; }
        public DateTime DateEmployment { get; }
        public Gender Gender { get; }
        public string Password { get; }
        public EmployeeType EmployeeType { get; }

        public int Age
        {
            get
            {
                DateTime today = DateTime.Today;

                return today.Year - BirthDate.Year;
            }
        }

        //Constructor for employee's that need an id
        public Employee(int id, string firstName, string lastName, DateTime birthDate, DateTime dateEmployment, Gender gender, string password, EmployeeType employeeType)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            DateEmployment = dateEmployment;
            Gender = gender;
            Password = password;
            EmployeeType = employeeType;
        }

        //Overload for employee's that dont need an id
        public Employee(string firstName, string lastName, DateTime birthDate, DateTime dateEmployment, Gender gender, string password, EmployeeType employeeType)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            DateEmployment = dateEmployment;
            Gender = gender;
            Password = password;
            EmployeeType = employeeType;
        }
    }
}
