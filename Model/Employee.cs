﻿using System;
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
        public string Gender { get; }
        public string Password { get; }

        public int Age
        {
            get
            {
                DateTime today = DateTime.Today;

                return today.Year - BirthDate.Year;
            }
        }
    }
}
