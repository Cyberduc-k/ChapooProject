using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bill
    {
        public int Id { get; }
        public DateTime Date { get; }
        public Table Table { get; }
	    public List<Order> Order { get; }
        public double Price { get; }
        public Employee Employee { get; }

        public Bill(int id, DateTime date, Table table, List<Order> order,  double price,  Employee employee)
        {
            Id = id;
            Date = date;
            Table = table;
            Order = order;
            Price = price;
            Employee = employee;
        }
    }
}
