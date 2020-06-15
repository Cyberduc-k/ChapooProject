using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime TimeOrdering { get; set; }
        public DateTime TimeFinished { get; set; }
        public List<Dish> Dishes { get; }
        public List<Drink> Drinks { get; }
        public int EmployeeId { get; set; }
        public int TableId { get; set; }
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

        public Order(int id, DateTime timeOrdering, DateTime timeFinished, List<Dish> dishes, List<Drink> drinks, int employeeId, int tableId, OrderState state, string comment)
        {
            Id = id;
            TimeOrdering = timeOrdering;
            TimeFinished = timeFinished;
            Dishes = dishes;
            Drinks = drinks;
            EmployeeId = employeeId;
            TableId = tableId;
            State = state;
            Comment = comment;
        }

        public Order()
        {

        }
    }
}
