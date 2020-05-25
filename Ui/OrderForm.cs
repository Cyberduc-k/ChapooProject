using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;

namespace Ui
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logic.Order_Service orderService = new Order_Service();
           
            Dish steak = new Dish(1, "Hertenbiefstuk", "biefstuk met uien", "biefstuk, ui, zout", 25.00, 40, DishCategory.Hoofdgerechten);
            List<Dish> dishes = new List<Dish>();
            dishes.Add(steak);

            Drink tonic = new Drink(1, "Tonic", false, 2.50, 30);
            List<Drink> drinks = new List<Drink>();
            drinks.Add(tonic);

            //Employee employee = new Employee(1, "Rico", "Verhoeven", DateTime.Parse("15-05-1993"), DateTime.Parse("18-04-2020"), Gender.Male, "Pa$$w0rd", EmployeeType.Waiter);
            //Table table = new Table(1, 4, false);
            Order order = new Order(1, DateTime.Parse("5:34:50 PM"), DateTime.Parse("5:53:24 PM"), dishes, drinks, 1, 1, OrderState.Started, "Graag extra veel saus");
            orderService.AddOrder(order);
        }
    }
}
