using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bill
    {
        public int ID { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public Table Table { get; }
		public List<Item> Items { get; }
        public double Price { get; }
        public Employee Employee { get; }

        public Bill(int iD, string firstName, string lastName, Table table, double price,  Employee employee)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Table = table;
            Price = price;
            Employee = employee;
        }
    }
}
