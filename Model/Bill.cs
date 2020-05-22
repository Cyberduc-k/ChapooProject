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
        public Table tafel { get; }
		public List<Item> item { get; }
        public double Price { get; }
        public Employee employee { get; }

        public Bill(int iD, string firstName, string lastName, Table tafel, double price,  Employee employee)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Table = tafel;
            Price = price;
            Employee = employee;
            
        }
    }
}
