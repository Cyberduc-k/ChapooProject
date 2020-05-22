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
        public Table Table { get; }
	    public List<Item> Items { get; }
        public double Price { get; }
        public Employee Employee { get; }

        public Bill(int iD, Table table, List<Item> items, double price,  Employee employee)
        {
            ID = iD;
            Table = table;
            Items = items;
            Price = price;
            Employee = employee;
        }
    }
}
