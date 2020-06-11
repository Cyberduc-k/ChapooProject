using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Model;

namespace Ui
{
    public partial class MenuForm : Form
    {
        private Table tafel;
        private Order order;
        private Drink_Service drinkServive = new Drink_Service();
        private Dish_Service dishService = new Dish_Service();
        private Table_Service tableService = new Table_Service();
        private Employee employee;

        public MenuForm(Table tafel, Order order, Employee employee)
        {
            this.tafel = tafel;
            this.order = order;
            this.employee = employee;
            InitializeComponent();
        }

        private void lunchBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string maaltijd = btn.Text;
            this.Hide();
            LunchMenuForm form = new LunchMenuForm (tafel, order, employee, maaltijd);
            form.Show();
        }

        private void dinerBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string maaltijd = btn.Text;
            this.Hide();
            LunchMenuForm form = new LunchMenuForm(tafel, order, employee, maaltijd);
            form.Show();
        }

        private void drankBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string maaltijd = btn.Text;
            this.Hide();
            LunchMenuForm form = new LunchMenuForm(tafel, order, employee, maaltijd);
            form.Show();
        }

        private void bestellijstBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestelLijstFrom form = new BestelLijstFrom(tafel, order, employee);
            form.Show();
        }
    }
}
