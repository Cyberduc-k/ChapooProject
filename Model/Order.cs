using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public int Id { get; }
        public DateTime Date { get; }
        public DateTime TimeOrdering { get; }
        public DateTime TimeFinished { get; }
        public List<Dish> Dishes { get; }
        public List<Drink> Drinks { get; }
        public Employee Employee { get; }
        public Table Table { get; }
        public OrderState State { get; set; }
        public string Comment { get; }

        public double TotalPrice
        {
            get
            {
                double sum = 0.0;

                foreach (Dish dish in Dishes)
                    sum += dish.Price;

                foreach (Drink drink in Drinks)
                    sum += drink.Price;

                return sum;
            }
        }

        public Order(int id, DateTime date, DateTime timeOrdering, DateTime timeFinished, List<Dish> dishes, List<Drink> drinks, Employee employee, Table table, OrderState state, string comment)
        {
            Id = id;
            Date = date;
            TimeOrdering = timeOrdering;
            TimeFinished = timeFinished;
            Dishes = dishes;
            Drinks = drinks;
            Employee = employee;
            Table = table;
            State = state;
            Comment = comment;
        }
    }
}
