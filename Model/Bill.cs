using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bill
    {
        public int Id { get; set; }
        public DateTime Date { get; }
        public Table Table { get; }
	    public List<Order> Orders { get; }
        public Employee Employee { get; }

        public bool Payed { get; }

        public Bill(int id, DateTime date, Table table, List<Order> orders, Employee employee, bool payed)
        {
            Id = id;
            Date = date;
            Table = table;
            Orders = orders;
            Employee = employee;
            Payed = payed;
        }

        public Bill(DateTime date, Table table, List<Order> orders, Employee employee, bool payed)
        {
            Date = date;
            Table = table;
            Orders = orders;
            Employee = employee;
            Payed = payed;
        }

        public double Price
        {
            get
            {
                return Orders.Sum((order) =>
                    order.Dishes.Sum((dish) => dish.Price) +
                    order.Drinks.Sum((drink) => drink.Price)
                );
            }
        }
    }
}
