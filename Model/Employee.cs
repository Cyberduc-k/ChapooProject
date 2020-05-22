using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public int ID { get; }
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

        public Employee(int iD, string firstName, string lastName, DateTime birthDate, DateTime dateEmployment, string gender, string password, EmployeeType employeeType)
        {
            ID = iD;
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
